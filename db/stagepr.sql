	CREATE DATABASE GSPARC;
	GO
	USE GSPARC;
	GO
	drop database GSPARC
	CREATE TABLE StatusChauffeur(
		idStatus INT PRIMARY KEY,
		nomStatus VARCHAR(30)
		);

	CREATE TABLE StatusVehicule(
		idStatus INT PRIMARY KEY,
		nomStatus VARCHAR(30)
		);

		insert into StatusVehicule values(1,'Free')
		insert into StatusVehicule values(2,'Pro')


	CREATE TABLE Marque(
		idMarque INT PRIMARY KEY,
		nomMarque VARCHAR(30)
		);
		insert into Marque values(1,'Camio')
		insert into Marque values(2,'CamioZbel')

	CREATE TABLE Chauffeurs(
		idChauffeur INT IDENTITY(1,1) ,
		nomChauffeurs VARCHAR(50),
		prenomChauffeur VARCHAR(50),
		telChauffeur VARCHAR(20),
		statusChauffeur INT FOREIGN KEY REFERENCES StatusChauffeur(idStatus),
		photoChauffeur IMAGE,
		numeroPermis VARCHAR(30) UNIQUE,
		typePermis VARCHAR(10)
		);


	CREATE TABLE TypeVehicule(
		idType INT PRIMARY KEY,
		nomType VARCHAR(30)
		);
		insert into TypeVehicule values(1,'car')
		insert into TypeVehicule values(2,'voiture')


	CREATE TABLE Vehicule(
		idVehicule INT IDENTITY(1,1) PRIMARY KEY,
		matricule NVARCHAR(25) UNIQUE,
		typeVehicule INT FOREIGN KEY REFERENCES TypeVehicule(idType),
		DateAquisition DATE,
		Marque INT FOREIGN KEY REFERENCES Marque(idMarque),
		Modele VARCHAR(50),
		statusVehicule INT FOREIGN KEY REFERENCES StatusVehicule(idStatus),
		niveauCarburant INT,
		Kilometrage INT,
		Consomage DECIMAL(4,2),
		HorsePower INT,
		CapaciteReservoir INT
		);

		select * from Vehicule 

		delete from Vehicule where matricule=2
		delete from Vehicule where matricule=1
		delete from Vehicule where matricule=3
		delete from Vehicule where matricule=5
		delete from Vehicule where matricule=4
		alter table Vehicule alter column Consomage DECIMAL(4,2)

		truncate table Vehicule

	CREATE TABLE Grade (
			idGrade INT IDENTITY PRIMARY KEY,
			nomGrade VARCHAR(255));
	

	CREATE TABLE _Service (
			idService INT IDENTITY PRIMARY KEY,
			nomService VARCHAR(255));
	

	CREATE TABLE Fonctionnaire(
		idFonctionnaire INT IDENTITY PRIMARY KEY,
		CIN VARCHAR(20) UNIQUE,
		Nom VARCHAR(50),
		Prenom VARCHAR(50),
		Sexe VARCHAR(15),
		SituationFamiliale VARCHAR(50),
		DateNaissance DATE ,
		LieuNaissance VARCHAR(50),
		DateRecrutement DATE ,
		Email VARCHAR(255),
		Tel VARCHAR(25),
		Adresse VARCHAR(255),
		idGrade int foreign key references Grade(idGrade),
		idService int foreign key references _Service(idService)
	);

	CREATE TABLE Vidange(
		idVidange INT IDENTITY(1,1) PRIMARY KEY,
		idVehicule INT FOREIGN KEY REFERENCES Vehicule(idVehicule),
		DateVidange DATE,
		Kilometrage INT
		);

	CREATE TABLE Carburants(
		idCarburant INT IDENTITY(1,1) PRIMARY KEY,
		typeCarburant VARCHAR(50),
		prixCarburant DECIMAL(10,2),
		idVehicule INT FOREIGN KEY REFERENCES Vehicule(idVehicule),
		dateAchat DATE,
		quantite decimal(7,2)
		);

	CREATE TABLE Assurance(
		idAssurance INT IDENTITY(1,1) PRIMARY KEY,
		idVehicule INT FOREIGN KEY REFERENCES Vehicule(idVehicule),
		DateDebutAssurance DATE,
		DateFinAssurance DATE,
		CoutAssurance DECIMAL(12,2)
		);




	create table Mission (
		idMission int identity primary key ,
		DateDepart date ,
		DateRetour date ,
		LieuDepart varchar(255),
		Destination varchar(255),
		NombrePersonnes int ,
		_Object varchar(255),
		Distance int
	);

	CREATE TABLE Mission_Fonctionnaires(
		idMission int foreign key references Mission(idMission),
		idFonctionnaire int foreign key references Fonctionnaire(idFonctionnaire),
		PRIMARY KEY(idMission,idFonctionnaire)
		);


	CREATE TABLE Mission_Vehicules(
		idMission int foreign key references Mission(idMission),
		idVehicule int foreign key references Vehicule(idVehicule),
		PRIMARY KEY(idMission,idVehicule)
		);

	create table Maintenance (
		idMaintenance int identity primary key ,
		DateMaintenance date,
		_Description NVARCHAR(1024),
		Prix DECIMAL(13,2),
		idVehicule int foreign key references Vehicule(idVehicule)
	);

	CREATE TABLE Users(
		userID INT IDENTITY(1,1) PRIMARY KEY,
		userName VARChar(50) UNIQUE,
		Pass nvarchar(50));

	insert into Users values('admin','admin');
	insert into Users values('user','user');