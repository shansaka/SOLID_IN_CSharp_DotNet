using Interface_Segregation_Principle;

NormalWorker normalWorker = new NormalWorker();
normalWorker.Work();

SuperWorker superWorker = new SuperWorker();
superWorker.Work();
superWorker.Eat();
superWorker.Sleep();