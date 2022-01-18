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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientside
{

    public partial class Form1 : Form
    {
        bool control = false;
        TcpClient sclient = null;
        NetworkStream ns;
        List<Panel> listPanel = new List<Panel>();
        List<int> konum_id = new List<int>();
        int userId;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            sclient = new TcpClient("127.0.0.1", 8888);
            ns = sclient.GetStream();
            StreamReader sr = new StreamReader(ns);
            panel4.Visible = false;
            //txtservermessages.Text = "server>>" + sr.ReadLine();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            /*
            var pocoObject = new Person("ömer", "karadeniz");

            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(pocoObject);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            //The url to post to.
            var url = "https://localhost:44313/home/post";
            var client = new HttpClient();

            //Pass in the full URL and the json string content
            var response = await client.PostAsync(url, data);

            //It would be better to make sure this request actually made it through
            string result = await response.Content.ReadAsStringAsync();

            MessageBox.Show(result);
            //close out the client
            client.Dispose();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            NetworkStream ns = client.GetStream();
            BinaryWriter sw = new BinaryWriter(ns);
            sw.Write(textBox1.Text);
            sw.Write(textBox2.Text);
            sw.Flush();
            */
        }

        private void form_load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44373/");
            HttpResponseMessage response = await client.GetAsync("");
            var person = JsonConvert.DeserializeObject<List<Person>>(response.Content.ReadAsStringAsync().Result);
            foreach (Person p in person)
            {
                if (p.Name == giris_adi.Text && p.Password == giris_sifresi.Text)
                {
                    MessageBox.Show("Başarılı Giriş");
                    userId = p.Id;
                    control = true;
                    panel4.Visible = true;
                    panel1.Visible = false;
                    return;
                }
            }
            if (control == false)
            {
                MessageBox.Show("böyle bir kullanıcı bulunmamaktadır");
            }
            control = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            //panel5.Visible = false;
            //panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            kayit(kayit_adi.Text, kayıt_sifre.Text);
            kayit_adi.Text = "";
            kayıt_sifre.Text = "";
            panel2.Visible = false;

        }
        public async void kayit(string Name, string Password)
        {
            var pocoObject = new Person(0, kayit_adi.Text, kayıt_sifre.Text);

            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(pocoObject);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            //The url to post to.
            var url = "https://localhost:44373/home/post";
            var client = new HttpClient();

            //Pass in the full URL and the json string content
            var response = await client.PostAsync(url, data);

            //It would be better to make sure this request actually made it through
            string result = await response.Content.ReadAsStringAsync();

            //MessageBox.Show("kayıt yapıldı");
            //close out the client
            client.Dispose();
        }

        private async void button5_Click(object sender, EventArgs e)
        {


            var pocoObject = new Locations(0, lat.Text, lng.Text, userId);

            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(pocoObject);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            //The url to post to.
            var url = "https://localhost:44373/home/konum";
            var hclient = new HttpClient();

            //Pass in the full URL and the json string content
            var response = await hclient.PostAsync(url, data);

            //It would be better to make sure this request actually made it through
            string result = await response.Content.ReadAsStringAsync();
            hclient.Dispose();
            //MessageBox.Show("kayıt yapıldı");
            //close out the client
            lat.Text = "";
            lng.Text = "";
            NetworkStream ns = sclient.GetStream();
            BinaryWriter sw = new BinaryWriter(ns);
            /*
            sw.Write(lat.Text);
            sw.Write(lng.Text);
            sw.Write(userId);
            sw.Flush();
            */
            sw.Write("giriş");
            sw.Flush();

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            konum_id.Clear();
            panel4.Visible = false;
            panel5.Visible = true;
            list_add();


        }
        public async void list_add(){
          var client = new HttpClient();
          var uri = "https://localhost:44373/home/get";
          //client.BaseAddress = new Uri("https://localhost:44313/");
          HttpResponseMessage response = await client.GetAsync(uri);
          //Locations location;
           var location = JsonConvert.DeserializeObject<List<Locations>>(response.Content.ReadAsStringAsync().Result);
            foreach (Locations p in location)
            {
                konum_id.Add(p.Id);
                listBox1.Items.Add("latetitude:" + p.lat+""+ "longetitude:" + p.lng);

            }
}
        public async void delete(int id)
        {
            konum_id.Clear();
            //MessageBox.Show("" + id);
            var pocoObject = new IdList(id);

            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(pocoObject);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            //The url to post to.
            var url = "https://localhost:44373/home/sil";
            var client = new HttpClient();

            //Pass in the full URL and the json string content
            var response = await client.PostAsync(url, data);

            //It would be better to make sure this request actually made it through
            string result = await response.Content.ReadAsStringAsync();

            MessageBox.Show("giden id"+result);
            //close out the client
            client.Dispose();
            NetworkStream ns = sclient.GetStream();
            BinaryWriter sw = new BinaryWriter(ns);
            sw.Write("giriş");
            sw.Flush();
            listBox1.Items.Clear();
            list_add();
            
        } 

            private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedIndex);
            delete(konum_id[listBox1.SelectedIndex]);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            konum_id.Clear();
            listBox1.Items.Clear();
            panel5.Visible = false;
            panel4.Visible = true;
        }
    }
}
