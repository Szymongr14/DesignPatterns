using Observer;

var spam = new Newsletter();

var client1 = new Client("John");
var client2 = new Client("Andrew");
var client3 = new Client("Paul");

spam.AddObserver(client1);
spam.AddObserver(client2);
spam.AddObserver(client3);

spam.SetFields("mail_1");
spam.NotifyObservers();

spam.SetFields("mail_3");
spam.NotifyObservers();

spam.SetFields("mail4");
spam.NotifyObservers();