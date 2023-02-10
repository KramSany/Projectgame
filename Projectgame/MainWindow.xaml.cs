using Projectgame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projectgame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _firstPlayer = true;
        TicTacToe checkWin = new();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int row = 0;
            int column = 0;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button1.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button1.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int row = 0;
            int column = 1;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button2.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button2.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int row = 0;
            int column = 2;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button3.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button3.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int row = 1;
            int column = 0;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button4.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button4.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int row = 1;
            int column = 1;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button5.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button5.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            int row = 1;
            int column = 2;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button6.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button6.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            int row = 2;
            int column = 0;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button7.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button7.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            int row = 2;
            int column = 1;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button8.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button8.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            int row = 2;
            int column = 2;
            if (_firstPlayer == true)
            {
                if (checkWin.CheckPosition(row, column, _firstPlayer))
                {
                    button9.Content = 'X';
                    _firstPlayer = false;
                    if (checkWin.WinPositions() == 1)
                    {
                        MessageBox.Show("Победили крестики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 0)
                    {
                        MessageBox.Show("Победили нолики");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }

                    else if (checkWin.WinPositions() == 2)
                    {
                        MessageBox.Show("Ничья! Всё сначала!");
                        checkWin.ClearField();
                        checkWin = new TicTacToe();
                        button1.Content = ' ';
                        button2.Content = ' ';
                        button3.Content = ' ';
                        button4.Content = ' ';
                        button5.Content = ' ';
                        button6.Content = ' ';
                        button7.Content = ' ';
                        button8.Content = ' ';
                        button9.Content = ' ';
                    }
                }
            }
            else if (checkWin.CheckPosition(row, column, _firstPlayer))
            {
                button9.Content = 'O';
                _firstPlayer = true;
                if (checkWin.WinPositions() == 1)
                {
                    MessageBox.Show("Победили крестики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 0)
                {
                    MessageBox.Show("Победили нолики");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }

                else if (checkWin.WinPositions() == 2)
                {
                    MessageBox.Show("Ничья! Всё сначала!");
                    checkWin.ClearField();
                    checkWin = new TicTacToe();
                    button1.Content = ' ';
                    button2.Content = ' ';
                    button3.Content = ' ';
                    button4.Content = ' ';
                    button5.Content = ' ';
                    button6.Content = ' ';
                    button7.Content = ' ';
                    button8.Content = ' ';
                    button9.Content = ' ';
                }
            }

        }
    }
}
