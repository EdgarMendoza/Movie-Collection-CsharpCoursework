using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Collection
{
    public partial class Form1 : Form
    {
        ArrayList movies = new ArrayList();

        private void AddMovie(Movie entry)
        {
            movies.Add(entry);

            movieTitlesListBox.Items.Add(entry.Title);
            movieYearListBox.Items.Add(entry.Date);
            movieRuntimeListBox.Items.Add(entry.Runtime);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void readDataButton_Click(object sender, EventArgs e)
        {
            string fileName = filePathTxtBox.Text.Trim();
            string line;
            bool finished = false;
            string[] lineValue;
            StreamReader sr = new StreamReader(fileName);

            try
            {
                //Clear items from list boxes and movie arraylist if items are present and read data button is pressed
                if(movieTitlesListBox.Items.Count > 0)
                {
                    movieTitlesListBox.Items.Clear();
                    movieYearListBox.Items.Clear();
                    movieRuntimeListBox.Items.Clear();

                    movies.Clear();
                }

                while(!(finished))
                {
                    line = sr.ReadLine();

                    if (line != null)
                    {
                        lineValue = line.Split(',');

                        Movie entry = new Movie(lineValue[0], Convert.ToInt32(lineValue[1]), lineValue[2]);

                        AddMovie(entry);
                    }
                    else
                        finished = true;
                }

                
            }
            catch(FileNotFoundException fnf)
            {
                MessageBox.Show("File Not Found {0}", fnf.Message);
            }
            catch(DirectoryNotFoundException dnf)
            {
                MessageBox.Show("File Path Not Found {0}", dnf.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            string path = filePathTxtBox.Text.Trim();
            FileStream fs = null;
            StreamWriter sWriter = null;
            string output = null;
            Movie entry = null;

            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                fs = File.Create(path);
                sWriter = new StreamWriter(fs);

                for(int index = 0; index < movies.Count; index++)
                {
                    entry = (Movie)movies[index];
                    
                    output = String.Format("{0},{1},{2}", entry.Title, entry.Date, entry.Runtime);
                   
                    sWriter.WriteLine(output);

                    entry = null;
                    output = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sWriter.Flush();
                sWriter.Close();
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            string title = titleTxtBox.Text;
            int date = Convert.ToInt32(yearTxtBox.Text);
            string runtime = runtimeTxtBox.Text;

            Movie entry = new Movie(title, date, runtime);

            AddMovie(entry);

            titleTxtBox.Clear();
            yearTxtBox.Clear();
            runtimeTxtBox.Clear();
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            int index = movieTitlesListBox.SelectedIndex;

            movies.RemoveAt(index);
            movieTitlesListBox.Items.RemoveAt(index);
            movieYearListBox.Items.RemoveAt(index);
            movieRuntimeListBox.Items.RemoveAt(index);
        }
    }
}
