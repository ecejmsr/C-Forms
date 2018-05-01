using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace RestruantCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dir = AppDomain.CurrentDomain.BaseDirectory;
        string fileName = "ResturantList";
        List<Resturant> listOfRestruants = new List<Resturant>();

        public class Resturant
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string ZipCode { get; set; }
            public double AveRate { get; set; }
            public string Rating { get; set; }
            public string Review { get; set; }
            public List<double> RatingList = new List<double>();
            public List<string> ReviewList = new List<string>();

            public Resturant(string name, string address, string phonenumber, string zipcode, string rating, string review)
            {
                Name = name;
                Address = address;
                PhoneNumber = phonenumber;
                ZipCode = zipcode;
                RatingList.Add(Convert.ToDouble(rating));
                ReviewList.Add(review);
            }

            public bool Equals(Resturant other)
            {
                if (other == null) return false;
                if (this.Name != other.Name) return false;
                if (this.Address != other.Address) return false;
                if (this.ZipCode != other.ZipCode) return false;
                return true;
            }

            public double AddToRatings(double rate)
            {
                RatingList.Add(rate);
                return rate;
            }

            public void AddToReviews(string review)
            {
                ReviewList.Add(review);
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Resturant rest = new Resturant(NameText.Text, AddressText.Text, PhoneNumberText.Text,ZipCodeText.Text,RatingText.Text, ReviewText.Text);
                if (!listOfRestruants.Contains(rest))
                {
                listOfRestruants.Add(rest);
                }
                else
                {
                listOfRestruants.Add(rest);
                }
            NameText.Clear();
            AddressText.Clear();
            ZipCodeText.Clear();
            PhoneNumberText.Clear();
            RatingText.Clear();
            ReviewText.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            File.WriteAllText(dir + fileName, JsonConvert.SerializeObject(listOfRestruants));
            Application.Exit();
        }
    }
}
