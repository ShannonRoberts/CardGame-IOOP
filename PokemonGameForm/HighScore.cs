﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokemonGameForm
{
    public partial class HighScore : Form
    {

        private Score[] scores = new Score[11];
        private Score newScore;




        public HighScore()
        {
            InitializeComponent();

        }

        public void readFile()
        {
            string[] nameScorePair;
            
            
            StreamReader sr = new StreamReader("scores.txt");
            int index = 0;
            string line = sr.ReadLine();
            while (line != null)
            {

                if (index < 10)
                {
                    nameScorePair = line.Split(' ');

                    if (scores[index] != null)
                    {
                        Console.WriteLine(index);
                        scores[index].setName(nameScorePair[0]);
                        scores[index].setScore(int.Parse(nameScorePair[1]));
                        //Console.WriteLine(scores[index].getName() + scores[index].getScore());
                        index++;
                    }
                }
                line = sr.ReadLine();
            }
            
            sr.Close();
            scores[index] = newScore;
          
        }

        public void writeFile()
        {
            scoresLabel.Text = "";
            StreamWriter sw = new StreamWriter("scores.txt");
            for (int index = 0; index < scores.Length; index++)
            {
                string overview = "";
                if (scores[index] != null && scores[index].getScore() != 1)
                {
                    overview = scores[index].getName() + " " + scores[index].getScore().ToString();
                    //Console.WriteLine(scores[index].getName() + scores[index].getScore());
                    sw.WriteLine(overview);

                    scoresLabel.Text += overview + "\r\n";
                }

            }
            sw.Close();
        }


        public void fill()
        {

            for (int index = 0; index < scores.Length; index++)
            {
                if (scores[index] == null)
                {

                    scores[index] = new Score(1, "no-name"); 

                }

            }
        }


        public void removeLowestScore()
        {
            if (newScore != null)
            {
                scores[10] = null;
            }
        }

        public void Sort()
        {
            Array.Sort(scores);
        }



        public void setScore(Score newScore)
        {
            this.newScore = newScore;
            

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            fill();
            readFile();
            Sort();
            removeLowestScore();
            writeFile();
           
        }
    }

    
}
