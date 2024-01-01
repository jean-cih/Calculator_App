using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;

namespace NewCalculatorApp
{
    public partial class Form1 : Form
    {
        int countButton = 0;
        public Form1()
        {
            InitializeComponent();

            buttonSettings.Visible = true;
            buttonArrow.Visible = false;
            pictureBackSet.Visible = false;

            this.BackgroundImage = Properties.Resources.Background;
            this.pictureGray.Image = Properties.Resources.Gray;
            this.pictureGreen.Image = Properties.Resources.Green;
            this.pictureRed.Image = Properties.Resources.Red;
            this.pictureOrange.Image = Properties.Resources.Orange;
            this.picturePerson.Image = Properties.Resources.Person;
            this.pictureInput.Image = Properties.Resources.RectangleInput;
            this.pictureOutput.Image = Properties.Resources.RectangleOutput;
            this.pictureList.Image = Properties.Resources.RectangleList;
        }

        private string CalculateFormula(string action, string number)
        {
            try
            {
                double figure;
                double item = Convert.ToDouble(number);

                if (action == "q")
                {
                    if (item >= 0)
                    {
                        return Math.Sqrt(item).ToString("0.00000");
                    }
                    else
                    {
                        return "Отрицательное число";
                    }
                }
                else if (action == "l")
                {
                    if (item >= 0)
                    {
                        return Math.Log(item).ToString("0.00000");
                    }
                    else
                    {
                        return "Отрицательное число";
                    }
                }
                else if (action == "t")
                {   
                    if(countButton % 2 == 0)
                    {
                        figure = item;
                    }
                    else
                    {
                        if (item == 90)
                            return "Не существует";
                        figure = Math.PI * item / 180.0;
                    }
                    return Math.Tan(figure).ToString("0.00000");
                }
                else if (action == "s")
                {
                    if (countButton % 2 == 0)
                    {
                        figure = item;
                    }
                    else
                    {
                        figure = Math.PI * item / 180.0;
                    }
                    return Math.Sin(figure).ToString("0.00000");
                }
                else if (action == "c")
                {
                    if (countButton % 2 == 0)
                    {
                        figure = item;
                    }
                    else
                    {
                        figure = Math.PI * item / 180.0;
                    }
                    return Math.Cos(figure).ToString("0.00000");
                }
                else
                    return "";
            }
            catch(Exception ex)
            {
                return "Ошибка";
            }
            
        }
        private string CalculateMath(string numberOne, string action, string numberTwo)
        {
            try
            {
                double itemOne = Convert.ToDouble(numberOne);
                double itemTwo = Convert.ToDouble(numberTwo);

                if (action == "/")
                {
                    if (itemTwo != 0)
                    {
                        return (itemOne / itemTwo).ToString("0.00000");
                    }
                    else
                    {
                        return "Деление на ноль";
                    }
                }
                else if (action == "*")
                {
                    return (itemOne * itemTwo).ToString("0.00000");
                }
                else if (action == "+")
                {
                    return (itemOne + itemTwo).ToString("0.00000");
                }
                else if (action == "-")
                {
                    return (itemOne - itemTwo).ToString("0.00000");
                }
                else
                {
                    return "Нет действия между числами";
                }
            }
            catch(Exception ex)
            {
                return "Ошибка";
            }

        }
        private string Calculate(string text, bool sign = false)
        {
            listBox.Items.Clear();
            string temp = "";
            bool flag = false;
            int index = 0;
            double typeNumber;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '+' || text[i] == '-' || text[i] == '*' 
                    || text[i] == '/' || text[i] == 't' || text[i] == 's' 
                    || text[i] == 'c' || text[i] == 'q' || text[i] == 'l')
                {
                    listBox.Items.Add(temp);
                    listBox.Items.Add(text[i]);
                    temp = "";
                    if (i == 0 && (text[i] == '-' || text[i] == '+'))
                    {
                        index++;
                        flag = true;
                    } 
                }
                else
                {
                    temp += text[i];
                }
            }
            listBox.Items.Add(temp);

            if ((listBox.Items[index].ToString() == "-" || listBox.Items[index].ToString() == "+") && flag)
            {
                listBox.Items[0] = "0";
            }

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                    if (listBox.Items[i].ToString() == "q" || listBox.Items[i].ToString() == "l" 
                        || listBox.Items[i].ToString() == "t" || listBox.Items[i].ToString() == "s" 
                        || listBox.Items[i].ToString() == "c")
                    {                  
                        string result = CalculateFormula(listBox.Items[i].ToString(), listBox.Items[i + 1].ToString());
                        if (result == "Не существует") return "Не существует";
                        if (result == "Отрицательное число") return "Отрицательное число";
                        listBox.Items.RemoveAt(i + 1);
                        listBox.Items.RemoveAt(i);
                        listBox.Items.RemoveAt(i - 1);
                        listBox.Items.Insert(i - 1, result);
                        i = 0;
                    }
            }
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString() == "*" || listBox.Items[i].ToString() == "/")
                {
                    string result = CalculateMath(listBox.Items[i - 1].ToString(), listBox.Items[i].ToString(), listBox.Items[i + 1].ToString());
                    if (result == "Ошибка") return "Ошибка";
                    if (result == "Нет действия между числами") return "Нет действия между числами";
                    if (result == "Деление на ноль") return "Деление на ноль";
                    listBox.Items.RemoveAt(i - 1);
                    listBox.Items.RemoveAt(i - 1);
                    listBox.Items.RemoveAt(i - 1);
                    listBox.Items.Insert(i - 1, result);
                    i = 0;
                }
            }
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString() == "+" || listBox.Items[i].ToString() == "-")
                {
                    string result = CalculateMath(listBox.Items[i - 1].ToString(), listBox.Items[i].ToString(), listBox.Items[i + 1].ToString());
                    flag = false;
                    if (result == "Ошибка") return "Ошибка";
                    if (result == "Нет действия между числами") return "Нет действия между числами";
                    //typeNumber = Convert.ToDouble(result);
                    //if (typeNumber < 0 && sign)
                    //{
                    //    typeNumber = -typeNumber;
                    //    result = Convert.ToString(typeNumber);
                    //    sign = false;
                    //}
                    //if (sign)
                    //{
                    //    typeNumber = Convert.ToDouble(result);
                    //    if(typeNumber < 0)
                    //    {
                    //        typeNumber = -typeNumber;
                    //    }
                    //    result = Convert.ToString(typeNumber);
                    //    sign = false;
                    //}
                    listBox.Items.RemoveAt(i - 1);
                    listBox.Items.RemoveAt(i - 1);
                    listBox.Items.RemoveAt(i - 1);
                    listBox.Items.Insert(i - 1, result);
                    i = 0;
                }
            }
            return listBox.Items[0].ToString();
        }

        private string Search(string text)
        {
            bool open = false;
            bool close = false;
            int open_pos = 0;
            int close_pos = 0;
            bool signBorder = false;
            for (int i = 0; i < text.Length; i++)
            {
                signBorder = false;
                if (text[i] == '(')
                {
                    open = true;
                    open_pos = i;
                }
                if (text[i] == ')')
                {
                    if (open)
                    {
                        signBorder = true;
                        close = true;
                        close_pos = i;
                        string result = Calculate(text.Substring(open_pos + 1, close_pos - open_pos - 1), signBorder);
                        text = text.Remove(open_pos, close_pos - open_pos + 1);
                        text = text.Insert(open_pos, result);
                        i = 0;
                        open = false;
                        close = false;
                        signBorder = false;
                    }
                    else
                        return "Ошибка Нет открывающей скобки";
                }
            }
            if(open && !close)
            {
                return "Ошибка Нет закрывающей скобки";
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    if (text[i] == '(')
                        Search(text);
                }
            }
            return Calculate(text);
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            textOutput.Text = Search(textInput.Text);
        }

        private void labelRad_Click(object sender, EventArgs e)
        {
            countButton++;
            if (countButton % 2 != 0)
                labelRad.Text = "Deg";
            else
                labelRad.Text = "Rad";
        }

        private void ButtonRad_Click(object sender, EventArgs e)
        {
            countButton++;
            if (countButton % 2 != 0)
                labelRad.Text = "Deg";
            else
                labelRad.Text = "Rad";
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            buttonSettings.Visible = false;
            buttonArrow.Visible = true;
            pictureBackSet.Visible = true;
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            buttonSettings.Visible = true;
            buttonArrow.Visible = false;
            pictureBackSet.Visible = false;
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textInput.Clear();
        }
        private void pictureClear_Click(object sender, EventArgs e)
        {
            textInput.Clear();
        }
    }
}
