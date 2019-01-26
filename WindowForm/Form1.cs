using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2;

namespace WindowForm
{
    public partial class Form1 : Form
    {
        RatingUser Vasya = new RatingUser
            {
                Name = "Вася"
            };
        RatingUser Maria = new RatingUser
            {
                Name = "Маша"
            };
        RatingUser Lena = new RatingUser
            {
                Name = "Лена"
            };
        Animal Frog = new Animal
        {
            ClassName = "Лягушка"
        };
        Animal Snake = new Animal
        {
            ClassName = "Змея"
        };
        Animal Bear = new Animal
        {
            ClassName = "Медведь"
        };
        RatingSystem rateSystem = new RatingSystem();
        RecommendingSystem recommendingSystem = new RecommendingSystem();
        Top top = new Top();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RatingUser[] users = { Vasya, Maria, Lena };
            Animal[] animals = { Frog, Snake, Bear };
            foreach (var user in users)
            {
                user.RateRequest += rateSystem.RequestHandler;
                user.RecommendRequest += recommendingSystem.Recommend;
                rateSystem.RateUpdated += user.UpdateUserFavourites;
            };
            rateSystem.RateUpdated += top.RequestHandler;
            /* Test rates
             * 
             * user\animal  Frog    Snake   Bear
             * Vasya        2       5       6
             * Maria        3       2       6
             * Lena         4       5       3
             * 
             * ---Average Rate----
             *              3       4       5
             */

            Vasya.UserRate(Frog, 2);
            Vasya.UserRate(Snake, 5);
            Vasya.UserRate(Bear, 6);
            Maria.UserRate(Frog, 3);
            Maria.UserRate(Snake, 2);
            Maria.UserRate(Bear, 6);
            Lena.UserRate(Frog, 4);
            Lena.UserRate(Snake, 5);
            Lena.UserRate(Bear, 3);
            
            foreach (var user in users)
            {
                user.Recommend(top);
            }
            RateablesListBox.DataSource = animals;
            TopTextBox.Text = top.RateablesToString();
            foreach (var animal in Lena.Recommended)
            {
                RecommendedTextBox.Text += $"{animal.ToString()} ";
            }

            NameTextBox.Text = Lena.Name;
            LikesListBox.DataSource = Lena.Likes.ToList();
            DislikesListBox.DataSource = Lena.Dislikes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lena.UserRate(((Animal)RateablesListBox.SelectedItem), Convert.ToInt32(RateTextBox.Text));
        }
        
    }
}
