	create Database GestionParking;
	use GestionParking;

	------------------------------
	use master;
	drop database GestionParking ;
	------------------------------

	create table Authentification(
	   UserID varchar(255) primary key ,
	   Password varchar(max)
	);

	create table Utilisateur(
		UserID varchar(255) foreign key references Authentification(UserID)  primary key ,
		Nom varchar(255) ,
		Prenom varchar(255) ,
		Role varchar(255) default('user'),
		Picture Image,
		Blocked bit ,
	);

	Alter table Utilisateur 
	add Blocked bit null
	-----------------------------------

	create table Grade (
		GradeID int identity primary key,
		Nom varchar(255)
	);

	create table Service(
		ServiceID int identity primary key,
		Nom varchar(255)
	);

	create table Fonctionnaire(
	  FonctionnaireID int identity primary key,
	  Cin varchar(255),
	  NomFrancais varchar(255),
	  PrenomFrancais varchar(255),
	  NomArabe varchar(255),
	  PrenomArabe varchar(255),
	  Sexe varchar(1),
	  SituationFamiliale varchar(255),
	  DateNaissance date ,
	  DateRecrutement date ,
	  DiplomeObtenu varchar(255),
	  EffetEchelon date,
	  LieuNaissance varchar(255),
	  Email varchar(255),
	  Tel varchar(255),
	  Adresse varchar(255),
	  GradeID int foreign key references Grade(GradeID),
	  ServiceID int foreign key references Service(ServiceID)
	);

	create table Vehicule (
		VehiculeID int identity primary key,
		CoutAssurance float,
		CoutReparation float,
		DateAquisition date,
		DateDebutAssurance date ,
		Immatriculation varchar(255),
		Kilometrage int ,
		Puissance varchar(255),
		PeriodeVidange int ,
		ProcheVidange int ,
		CoutVidange float,
		CoutCarburant float
	);

	create table Mission (
		CodeMission int identity primary key ,
		DateDepart date ,
		DateRetour date ,
		Lieu varchar(255),
		NombrePersonnes int ,
		Object varchar(255),
		Ville varchar(255),
		Kilometrage int,
		FonctionnaireID int foreign key references Fonctionnaire(FonctionnaireID),
		VehiculeID int foreign key references Vehicule(VehiculeID)
	);

	create table Corbillard (
		CorbillardID int identity primary key ,
		Adresse varchar(255),
		Cin varchar(255),
		DateDepart date ,
		Depart varchar(255),
		Destination varchar(255),
		Kilometrage int ,
		Nom varchar(255),
		Prenom varchar(255),
		FonctionnaireID int foreign key references Fonctionnaire(FonctionnaireID),
		VehiculeID int foreign key references Vehicule(VehiculeID)
	);

	create table Maintenance (
		MaintenanceID int identity primary key ,
		DateMaintenance date ,
		Prix float ,
		Type varchar(255),
		VehiculeID int foreign key references Vehicule(VehiculeID)
	);

	create table Vidange (
		VidangeID int identity primary key ,
		DateVidange date ,
		Prix float ,
		Type varchar(255),
		VehiculeID int foreign key references Vehicule(VehiculeID)
	);

	create table Carburant (
		CarburantID int identity Primary key ,
		DateCarburant date ,
		Prix float ,
		Quantite int ,
		Type varchar(255),
		VehiculeID int foreign key references Vehicule(VehiculeID)
	);