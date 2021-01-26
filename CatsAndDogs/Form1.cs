using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CatsAndDogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void getDog_Click(object sender,EventArgs e)
        {
            string dogImage = getDogUrl();
            pictureBox1.ImageLocation = dogImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public static string getDogUrl()
        {
            string url = "https://dog.ceo/api/breeds/image/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            string imageURL;

            using (var responsreReader = new StreamReader(webStream))
            {
                var response = responsreReader.ReadToEnd();
                Dog dog = JsonConvert.DeserializeObject<Dog>(response);

                imageURL = dog.message;
            }

            return imageURL;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string catImage = getACat();
            catpicture.ImageLocation = catImage;
            catpicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void catpicture_Click(object sender, EventArgs e)
        {
            
        }

        public static string getACat()
        {
            string url = "http://api.thecatapi.com/v1/images/search";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            string catImage;

            using (var responsreReader = new StreamReader(webStream))
            {
                var response = responsreReader.ReadToEnd();
                JavaScriptSerializer ser = new JavaScriptSerializer();
               

                

                List<Cat> catList = ser.Deserialize<List<Cat>>(response);
                catImage = catList[0].url;
            }

            return catImage;





        }


    }

}
