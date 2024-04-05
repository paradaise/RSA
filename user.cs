
namespace Users
{
    public class User : IUser //создаем класс User который реализует интерфейс
    {
        protected RSACryptoServiceProvider rsa; //Объявляется переменная "rsa" типа "RSACryptoServiceProvider", которая будет использоваться для шифрования и расшифровки сообщений.


        public User() // в конструкторе классе инициализируем переменную rsa с длинной ключа 2048 бит
        {
            rsa = new RSACryptoServiceProvider(2048); //в этой переменной хранится и открытый и закрытый ключ который класс генерирует
            //2048 это значит что p * q будет 2048битным числом(617 знаков) 
            //с 2015 года рекомендуют использовать именно эту длинну ключа,его не могут разложить
            //наибольшее факторизованое число имеет 830бит
        }

        public virtual string EncryptMessage(string message) // метод для шифрования сообщения
        {
            //у объекта rsa вызываем метод Encrypt он принимает 2 параметра(сообщение и исп/не исп foAEP)
            //кодирует строку message в последовательность байтов с использованием кодировки UTF-8.
            //Это нужно для того, чтобы сообщение можно было зашифровать (так как шифрование RSA работает с байтами).
            byte[] encryptedMessage = rsa.Encrypt(Encoding.UTF8.GetBytes(message), fOAEP: false);
            //возвращаем зашифрованное сообщение в текстовом виде закодировов еще сверу Base64
            return Convert.ToBase64String(encryptedMessage);
        }

        public virtual string DecryptMessage(string encryptedMessage) //метод для дешифрации сообщения
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedMessage); //делаем из строки снова массив байт

            byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, fOAEP: false); //у объекта rsa вызываем метод Decrypt
            //он принимает зашифрованное сообщение и исп/не исп f0AEP 
            //возвращаем расшифрованное сообщение в виде строки.
            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}