public interface IUser 
    //создаем интерфейс подразумевая что классы которые будут его реализовывать должны иметь 2 метода,принимающие и возвращающие строку
{
    string EncryptMessage(string message);
    string DecryptMessage(string encryptedMessage);
}

