// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Dependency: Entity of an object to be addicted entity of an object 
// for example: A mause has not a battery or electiricity it won't be useful.
// Inversion: large system; it should not create the object it depends on, instead it should import it from outside.


//Reporter reporter = new Reporter();

Reporter mailReporter = new Reporter(new MailSender());
Reporter telegramReporter = new Reporter(new TelegramSender());
Reporter BiPReporter = new Reporter(new BiPSender());
Reporter whatsappReporter = new Reporter(new WhatsappSender());

mailReporter.SendReport();
BiPReporter.SendReport();
telegramReporter.SendReport();
whatsappReporter.SendReport();