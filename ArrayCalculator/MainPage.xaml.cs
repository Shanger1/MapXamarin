using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArrayCalculator
{
    public partial class MainPage : ContentPage
    {
        int[,] matrixArray1 = new int[3,3];
        int[,] matrixArray2 = new int[3,3];
        int[,] matrixArray3 = new int[3,3];

        public MainPage()
        {
            InitializeComponent();
        }

        public void initializeArraysToCount() {
            matrixArray1[0, 0] = Int32.Parse(entry0.Text);
            matrixArray1[0, 1] = Int32.Parse(entry1.Text);
            matrixArray1[0, 2] = Int32.Parse(entry2.Text);
            matrixArray1[1, 0] = Int32.Parse(entry3.Text);
            matrixArray1[1, 1] = Int32.Parse(entry4.Text);
            matrixArray1[1, 2] = Int32.Parse(entry5.Text);
            matrixArray1[2, 0] = Int32.Parse(entry6.Text);
            matrixArray1[2, 1] = Int32.Parse(entry7.Text);
            matrixArray1[2, 2] = Int32.Parse(entry8.Text);

            matrixArray2[0, 0] = Int32.Parse(entry9.Text);
            matrixArray2[0, 1] = Int32.Parse(entry10.Text);
            matrixArray2[0, 2] = Int32.Parse(entry11.Text);
            matrixArray2[1, 0] = Int32.Parse(entry12.Text);
            matrixArray2[1, 1] = Int32.Parse(entry13.Text);
            matrixArray2[1, 2] = Int32.Parse(entry14.Text);
            matrixArray2[2, 0] = Int32.Parse(entry15.Text);
            matrixArray2[2, 1] = Int32.Parse(entry16.Text);
            matrixArray2[2, 2] = Int32.Parse(entry17.Text);
        }

        public void initializeArray3()
        {
            entry18.Text = matrixArray3[0, 0].ToString();
            entry19.Text = matrixArray3[0, 1].ToString();
            entry20.Text = matrixArray3[0, 2].ToString();
            entry21.Text = matrixArray3[1, 0].ToString();
            entry22.Text = matrixArray3[1, 1].ToString();
            entry23.Text = matrixArray3[1, 2].ToString();
            entry24.Text = matrixArray3[2, 0].ToString();
            entry25.Text = matrixArray3[2, 1].ToString();
            entry26.Text = matrixArray3[2, 2].ToString();
        }

        void sumButtonClicked(object sender, EventArgs args)
        {
            initializeArraysToCount();
            addMatrix();
            initializeArray3();
            matrix1Label.IsVisible = false;
            matrix1.IsVisible = false;
            matrix2Label.IsVisible = false;
            matrix2.IsVisible = false;
            matrix3Label.IsVisible = true;
            matrix3.IsVisible = true;
            buttons1.IsVisible = false;
            buttons2.IsVisible = false;
            buttons3.IsVisible = true;

        }

        void subButtonClicked(object sender, EventArgs args)
        {
            initializeArraysToCount();
            subMatrix();
            initializeArray3();
            matrix1Label.IsVisible = false;
            matrix1.IsVisible = false;
            matrix2Label.IsVisible = false;
            matrix2.IsVisible = false;
            matrix3Label.IsVisible = true;
            matrix3.IsVisible = true;
            buttons1.IsVisible = false;
            buttons2.IsVisible = false;
            buttons3.IsVisible = true;

        }

        void timesButtonClicked(object sender, EventArgs args)
        {
            initializeArraysToCount();
            timesMatrix();
            initializeArray3();
            matrix1Label.IsVisible = false;
            matrix1.IsVisible = false;
            matrix2Label.IsVisible = false;
            matrix2.IsVisible = false;
            matrix3Label.IsVisible = true;
            matrix3.IsVisible = true;
            buttons1.IsVisible = false;
            buttons2.IsVisible = false;
            buttons3.IsVisible = true;

        }

        void backButtonClicked(object sender, EventArgs args)
        {
            matrix1Label.IsVisible = true;
            matrix1.IsVisible = true;
            matrix2Label.IsVisible = true;
            matrix2.IsVisible = true;
            matrix3Label.IsVisible = false;
            matrix3.IsVisible = false;
            buttons1.IsVisible = true;
            buttons2.IsVisible = true;
            buttons3.IsVisible = false;
        }

        void addMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    matrixArray3[i, j] = matrixArray1[i, j] + matrixArray2[i, j];
                }
            }
        }

        void subMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixArray3[i, j] = matrixArray1[i, j] - matrixArray2[i, j];
                }
            }
        }

        void timesMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixArray3[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrixArray3[i, j] += matrixArray1[i, k] * matrixArray2[k, j]; 
                    } 
                }
            }
        }

    }


}
