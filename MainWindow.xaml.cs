using System;
using System.Security.Cryptography;
using System.Windows;
using AliceAndBob;
using Users;

namespace RSAEncryptionApp
{
    public partial class MainForm
    {
        //определяем 2 объекта типа User
        private User alice; 
        private User bob;

        public MainForm()
        {
            InitializeComponent();
            //инициализируем Алису и Боба
            alice = new AliceAndBob.AliceAndBob();
            bob = new Bob();
        }
        // В этом методе выполняется шифрование сообщения от Alice к Bob.
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            
            string messageFromAlice = AliceMessageTextBox.Text; //считываем сообщение из текст бокса
            
            
            try
            {
                string encryptedMessageStr = bob.EncryptMessage(messageFromAlice); //вызываем метод Шифрования сообщения
                BobEncryptedMessageTextBox.Text = encryptedMessageStr;//и выводим зашифрвоанное сообщение для Боба
            }
            //ловим ошибку класса Криптографии
            catch (CryptographicException ex)
            {
                MessageBox.Show("Error encrypting message: " + ex.Message);
            }
            //или другую любую
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //В этом методе выполняется шифрование сообщения от Bob к Alice
        private void ReplyButton_Click(object sender, EventArgs e)
        {
            string messageFromBob = BobMessageTextBox.Text; //считываем сообщение из текстбокса
            try
            {
                string encryptedMessageStr = alice.EncryptMessage(messageFromBob); //вызываем метод Шифрования сообщения
                AliceEncryptedMessageTextBox.Text = encryptedMessageStr;//и выводим зашифрвоанное сообщение для Алисы
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Error encrypting message: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //расшифровка сообщения:

        //Расшифрование сообщения от Боба
        private void DecryptAliceMessageButton_Click(object sender, EventArgs e)
        {
            string encryptedMessageFromBob = AliceEncryptedMessageTextBox.Text;//считываем зашифрованное сообщение
            try
            {
                string decryptedMessageStr = alice.DecryptMessage(encryptedMessageFromBob); //вызываем метод дешифрации передав туда зашифрованное сообщение
                AliceDecryptedMessageTextBox.Text = decryptedMessageStr;//далее расшифрованное сообщение выводим в текстбокс
            }
            //если не получилось ловим ошибки
            catch (CryptographicException ex)
            {
                MessageBox.Show("Error decrypting message: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //Расшифрование сообщения от Алисы
        private void DecryptBobMessageButton_Click(object sender, EventArgs e)
        {
            string encryptedMessageFromAlice = BobEncryptedMessageTextBox.Text;
            try
            {
                string decryptedMessageStr = bob.DecryptMessage(encryptedMessageFromAlice);
                BobDecryptedMessageTextBox.Text = decryptedMessageStr;
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Error decrypting message: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }


    

    

    
}