using Users;

namespace AliceAndBob
{
    public class AliceAndBob : User //создаем класс Алисы наследуемся от Юсера и переопределяем метод шифрования сообщения
    {
        public override string EncryptMessage(string message)
        {
            return base.EncryptMessage(message); //возвращаем зашифрованное сообщение
            //с помощью оператора base,вызывается базовая реализация метода, предоставленная классом User
        }
    }

    public class Bob : User //создаем класс Боб наследуемся от Юзера и переопределяем метод дешифрования сообщения
    {
        public override string DecryptMessage(string encryptedMessage)
        {
            return base.DecryptMessage(encryptedMessage); //возвращаем расшифрованное сообщение
            //с помощью оператора base,вызывается базовая реализация метода, предоставленная классом User
        }
    }
}