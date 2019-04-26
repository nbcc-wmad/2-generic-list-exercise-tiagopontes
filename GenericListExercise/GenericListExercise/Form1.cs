using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Tiago Pontes
 * Date: July 26, 2019.
 * 
 */

namespace GenericListExercise
{
    public partial class Form1 : Form
    {
        public struct Score
        {
            public int maxpoint;
            public string letter;
            
        }

        private Score score;

        private ArrayList grades = new ArrayList();

        private List<Score> scoreList = new List<Score>();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnGrade_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtScore.Text, out int user);

                string message = string.Empty;


                foreach (Score item in grades)
                {
                    if (user <= item.maxpoint)
                    {
                        MessageBox.Show($"Grade is {item.letter}");
                        break;
                    }
                                      
                }

                txtScore.ResetText();
                txtScore.Focus();


                // part that I'm a little confused
                //Score scoreLetter = scoreList.Where(x => x.maxpoint >= user).FirstOrDefault();

                //MessageBox.Show($"{scoreLetter.letter}");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score.maxpoint = 299;
            score.letter = "F";
            scoreList.Add(score);
            grades.Add(score);

            score.maxpoint = 349;
            score.letter = "D";
            scoreList.Add(score);
            grades.Add(score);

            score.maxpoint = 399;
            score.letter = "C";
            scoreList.Add(score);
            grades.Add(score);

            score.maxpoint = 449;
            score.letter = "B";
            scoreList.Add(score);
            grades.Add(score);

            score.maxpoint = 500;
            score.letter = "A";
            scoreList.Add(score);
            grades.Add(score);

        }
    }
}
