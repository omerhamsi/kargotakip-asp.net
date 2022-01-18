using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMaps
{
    public partial class Form1 : Form
    {
        public List<PointLatLng> points = new List<PointLatLng>();
        public List<PointLatLng> start_points = new List<PointLatLng>();
        List<GMapMarker> markers_point = new List<GMapMarker>();
        List<GMapOverlay> markers_point_2 = new List<GMapOverlay>();
        List<GMapOverlay> routes_point = new List<GMapOverlay>();
        int index = 0;
        private List<PointLatLng> points_;
        NetworkStream ns;
        int inception=0;
        int userId;
        Thread dinleyici;
        public Form1()
        {
           
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            save();
        }
        public void save()
        {
            points_ = new List<PointLatLng>();
            TcpListener server = new TcpListener(8888);
            server.Start();
            Socket socketForClient = server.AcceptSocket();
            if (socketForClient.Connected)
            {
                //timer1.Stop();
                ns = new NetworkStream(socketForClient);
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine("hellooooo");
                sw.Flush();
                dinleyici = new Thread(baglanti_dinle);
                dinleyici.Start();
            }
            //points 
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyA2ttnIYe6bGzSUPuXbwdzU_K11tSOWth0";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
        }
        public async void baglanti_dinle()
        {
            //map.Overlays.Clear();
            //MessageBox.Show("girdii");
            while (true)
            {
                //map.Overlays.Clear();
                BinaryReader sr = new BinaryReader(ns);
                string giris = Convert.ToString(sr.ReadString());
                //MessageBox.Show("" + giris);
                //double lng_client = Convert.ToDouble(sr.ReadString());
                //MessageBox.Show("fasfsaffdfergfrefer");
                
                if (giris !=null)
                {
                    map.Overlays.Clear();
                    points.Clear();
                    //MessageBox.Show("oooooooooo");
                    //userId = Convert.ToInt32(sr.ReadInt32());
                    var client = new HttpClient();
                    var uri = "https://localhost:44373/home/get";
                    //client.BaseAddress = new Uri("https://localhost:44313/");
                    HttpResponseMessage response = await client.GetAsync(uri);
                    //Locations location;
                    var location = JsonConvert.DeserializeObject<List<Locations>>(response.Content.ReadAsStringAsync().Result);
                    foreach (Locations p in location)
                    {

                        //MessageBox.Show("" + p.lat, "" + p.lng);
                        double lat = Convert.ToDouble(p.lat);
                        double lng = Convert.ToDouble(p.lng);
                        GMapProviders.GoogleMap.ApiKey = @"AIzaSyA2ttnIYe6bGzSUPuXbwdzU_K11tSOWth0";
                        GMaps.Instance.Mode = AccessMode.ServerAndCache;
                        map.CacheLocation = @"cache";
                        map.DragButton = MouseButtons.Left;
                        map.MapProvider = GMapProviders.GoogleMap;
                        map.Position = new PointLatLng(lat, lng);
                        points.Add(new PointLatLng(lat, lng));
                        map.MinZoom = 5;
                        map.MaxZoom = 100;
                        map.Zoom = 10;



                        PointLatLng point = new PointLatLng(lat, lng);
                        GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                        //marker
                        GMapOverlay markers = new GMapOverlay("markers");
                        markers_point_2.Add(markers);
                        markers_point.Add(marker);
                        markers.Markers.Add(marker);
                        map.Overlays.Add(markers);

                    }
                    //points.Add(new PointLatLng(lat_client, lng_client));
                    //map.Refresh();
                    ShortestPath(points, 0);
                    //MessageBox.Show("sdsadsada");
                    map.Zoom = 11;
                }
                
                //save();
                //break;
                
                /*
                points.Add(new PointLatLng(lat, lng));
                //MessageBox.Show(userId + "");
                GMapProviders.GoogleMap.ApiKey = @"AIzaSyA2ttnIYe6bGzSUPuXbwdzU_K11tSOWth0";
                GMaps.Instance.Mode = AccessMode.ServerAndCache;
                map.CacheLocation = @"cache";
                map.DragButton = MouseButtons.Left;
                map.MapProvider = GMapProviders.GoogleMap;
                map.Position = new PointLatLng(lat, lng);
                map.MinZoom = 5;
                map.MaxZoom = 100;
                map.Zoom = 10;
                
                foreach(PointLatLng i in points)
                {
                    PointLatLng point_n = new PointLatLng(i.Lat, i.Lng);
                    GMapMarker marker = new GMarkerGoogle(point_n, GMarkerGoogleType.red_dot);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers_point_2.Add(markers);
                    markers_point.Add(marker);
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                }*/
                //Thread.Sleep(2000);

                //marker
                //break;
                
            }
            //deneme();
           

        }
        public void deneme()
        {
            map.Refresh();
            ShortestPath(points, inception);
            //timer1.Interval = 5000;
            //timer1.Start();
            MessageBox.Show("sdsadsada");
            map.Zoom = 11;
        }


        public List<Standort> Standorte(List<PointLatLng> points, int start)
        {
            List<Standort> standorte = new List<Standort>();
            start_points.Add(points[start]);
            for (int i = 0; i < points.Count; i++)
            {

                var route = GoogleMapProvider.Instance.GetRoute(points[start], points[i], false, false, 15);
                var r = new GMapRoute(route.Points, "MY ROUTE");
                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);

                Standort st = new Standort();
                st.from = start;
                st.to = i;
                st.distance = route.Distance;
                standorte.Add(st);

            }
            return standorte;
        }


        public double MinDistance(List<Standort> standorte)
        {
            double minDistance = 9999999999999999999;
            for (int i = 0; i < standorte.Count; i++)
            {
                if (standorte[i].distance != 0 && standorte[i].distance < minDistance)
                {
                    minDistance = standorte[i].distance;
                }
            }

            return minDistance;
        }

        public Standort TargetPoint(List<PointLatLng> points, List<Standort> standorte, double minDistance)
        {
            Standort st = new Standort();
            for (int i = 0; i < standorte.Count; i++)
            {
                if (standorte[i].distance == minDistance)
                {
                    st.from = standorte[i].from;
                    st.to = standorte[i].to;
                    st.distance = standorte[i].distance;
                }
            }

            return st;
        }

        public void DrawDestination(List<PointLatLng> points, Standort st)
        {
            var route = GoogleMapProvider.Instance.GetRoute(points[st.from], points[st.to], false, false, 15);
            var r = new GMapRoute(route.Points, "MY ROUTE");
            r.Stroke.Width = 2;
            r.Stroke.Color = Color.Blue;
            var routes = new GMapOverlay("routes");
            routes_point.Add(routes);
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            lblkm.Text = route.Distance + "km";


        }
        public PointLatLng DestinationPoint(List<PointLatLng> points, int dest)
        {
            PointLatLng destination = new PointLatLng();
            destination.Lat = points[dest].Lat;
            destination.Lng = points[dest].Lng;
            return destination;
        }
        public int NewDestination(List<PointLatLng> points, PointLatLng destination)
        {
            int start = -1;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].Lat == destination.Lat && points[i].Lng == destination.Lng)
                {
                    start = i;
                }
            }
            return start;
        }
        public void ShortestPath(List<PointLatLng> points, int start)
        {
            while (points.Count > 1)
            {
                List<Standort> standorte = Standorte(points, start);
                double minDistance = MinDistance(standorte);
                Standort st = TargetPoint(points, standorte, minDistance);
                DrawDestination(points, st);
                PointLatLng destination = new PointLatLng();
                destination = DestinationPoint(points, st.to);
                points.RemoveAt(start);
                start = NewDestination(points, destination);
                inception = start;
                //MessageBox.Show("inception" + inception);
                standorte.Clear();
            }
            //timer1.Interval = 8000;
            //timer1.Start();
        }
        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(textLat.Text);
            double lng = Convert.ToDouble(textLong.Text);
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyA2ttnIYe6bGzSUPuXbwdzU_K11tSOWth0";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(lat, lng);
            points.Add(new PointLatLng(lat, lng));
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;



            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            //marker
            GMapOverlay markers = new GMapOverlay("markers");
            markers_point_2.Add(markers);
            markers_point.Add(marker);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            points.Clear();
        }

        private async void btnRoute_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var uri = "https://localhost:44373/home/get";
            //client.BaseAddress = new Uri("https://localhost:44313/");
            HttpResponseMessage response = await client.GetAsync(uri);
            //Locations location;
            var location = JsonConvert.DeserializeObject<List<Locations>>(response.Content.ReadAsStringAsync().Result);
            foreach (Locations p in location)
            {
                double lat = Convert.ToDouble(p.lat);
                double lng = Convert.ToDouble(p.lng);
                GMapProviders.GoogleMap.ApiKey = @"AIzaSyA2ttnIYe6bGzSUPuXbwdzU_K11tSOWth0";
                GMaps.Instance.Mode = AccessMode.ServerAndCache;
                map.CacheLocation = @"cache";
                map.DragButton = MouseButtons.Left;
                map.MapProvider = GMapProviders.GoogleMap;
                map.Position = new PointLatLng(lat, lng);
                points.Add(new PointLatLng(lat, lng));
                map.MinZoom = 5;
                map.MaxZoom = 100;
                map.Zoom = 10;



                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                //marker
                GMapOverlay markers = new GMapOverlay("markers");
                markers_point_2.Add(markers);
                markers_point.Add(marker);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
            }
            //int start = Convert.ToInt32(textStart.Text);
            ShortestPath(points,0);
            //timer1.Interval = 5000;
            //timer1.Start();
            
            map.Zoom = 11;
        }

        private void timer_click(object sender, EventArgs e)
        {
             MessageBox.Show("timerrrr");
            if (index == start_points.Count)
            {
                timer1.Stop();
                timer1.Enabled = false;

                return;
            }
            int control = 0;
            //MessageBox.Show("girdii");
            foreach (GMapMarker indis in markers_point)
                {
                    //System.Threading.Thread.Sleep(1000);
                    if (indis.Position.Lat == start_points[index].Lat && indis.Position.Lng == start_points[index].Lng)
                    {
                        map.Overlays.Remove(markers_point_2[control]);
                        map.Overlays.Remove(routes_point[index]);
                        map.Refresh();
                        //map.Refresh();
                        //control++;
                        index++;
                      return;
                    }
                    control++;
                }
                control = 0;
            
        }
    }
}