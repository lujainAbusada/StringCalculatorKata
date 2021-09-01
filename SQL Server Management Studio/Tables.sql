USE DoctorWho;


CREATE TABLE Enemy
(  
    EnemyId int  IDENTITY(1,1) NOT NULL PRIMARY KEY  
    ,EnemyName VARCHAR(100) NOT NULL  
    ,_Description VARCHAR(1000)
);  


CREATE TABLE  Author
(  
    AuthorId int IDENTITY(1,1)  NOT NULL  PRIMARY KEY
    ,AuthorName VARCHAR(100) NOT NULL  
);  


CREATE TABLE  Companion
(  
    CompanionId int IDENTITY(1,1)  NOT NULL  PRIMARY KEY
    ,CompanianName VARCHAR(100) NOT NULL  
    ,WhoPlayed VARCHAR(1000)
);


CREATE TABLE  Doctor
(  
    DoctorId int IDENTITY(1,1)  NOT NULL  PRIMARY KEY
    ,DoctorName VARCHAR(100) NOT NULL  
    ,DoctorNumber int 
	, BirthDate Date
	, FirstEpisodeDate Date
	,LastEpisodeDate Date
);  

   
CREATE TABLE  Episode
(  
    
	EpisodeId int IDENTITY(1,1) NOT NULL  PRIMARY KEY
	,SeriesNumber int NOT NULL  
    ,EpisodeNumber int  
    ,EpisodeType VARCHAR(1000)
	,Title VARCHAR(100) NOT NULL 
	, EpisodeDate Date
	, AuthorId int
	, DoctorId int
	,Notes VARCHAR(100) NOT NULL  
	,FOREIGN KEY (AuthorId) REFERENCES Author(AuthorId)
	,FOREIGN KEY (DoctorId) REFERENCES Doctor(DoctorId)

	,  CONSTRAINT fk_ep_Author_id
    FOREIGN KEY (AuthorId)
    REFERENCES Author (AuthorId)
    ON DELETE CASCADE

	,  CONSTRAINT fk_ep_Docotor_id
    FOREIGN KEY (DoctorId)
    REFERENCES Doctor (DoctorId)
    ON DELETE CASCADE
	

);  
CREATE TABLE EpisodeCompanion
(  
     EpisodeCompanionId int IDENTITY(1,1)  NOT NULL  PRIMARY KEY
    , EpisodeId int NOT NULL  
	, CompanionId int NOT NULL  
	,FOREIGN KEY (CompanionId) REFERENCES Companion(CompanionId)
	,FOREIGN KEY (EpisodeId) REFERENCES Episode(EpisodeID)

	,  CONSTRAINT fk_EpCompanion_Companion_id
    FOREIGN KEY (Companionid)
    REFERENCES Companion (Companionid)
    ON DELETE CASCADE

	,  CONSTRAINT fk_EpCompanion_Episode_id
    FOREIGN KEY (Episodeid)
    REFERENCES Episode (Episodeid)
    ON DELETE CASCADE
);  

  


CREATE TABLE EpisodeEnemy
(  
    EpisodeEnemyId int IDENTITY(1,1)  NOT NULL PRIMARY KEY 
    ,EpisodeId int NOT NULL  
    ,EnemyId int NOT NULL
	,FOREIGN KEY (EnemyId) REFERENCES Enemy(EnemyId)
	,FOREIGN KEY (EpisodeId) REFERENCES Episode(EpisodeID)
	,  CONSTRAINT fk_EpEnemy_Enemy_id
    FOREIGN KEY (Enemyid)
    REFERENCES Enemy (Enemyid)
    ON DELETE CASCADE

	,  CONSTRAINT fk_EpEnemy_Episode_id
    FOREIGN KEY (Episodeid)
    REFERENCES Episode (Episodeid)
    ON DELETE CASCADE

);

