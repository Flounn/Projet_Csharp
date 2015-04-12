/*==============================================================*/
/* Nom de SGBD :  MySQL 5.0                                     */
/* Date de création :  11/04/2015 13:35:41                      */
/*==============================================================*/


drop table if exists CARTE_BANCAIRE;

drop table if exists CHEQUIER;

drop table if exists CLIENT;

drop table if exists COMPTE;

drop table if exists CONTRAT;

drop table if exists CONTRAT_CREDIT;

drop table if exists CONTRAT_EPARGNE;

drop table if exists HISTO_ETUDIANT;

drop table if exists MOYEN_PAIEMENT;

drop table if exists OPERATION;

drop table if exists PRODUIT;

drop table if exists TYPE_CARTE;

/*==============================================================*/
/* Table : CARTE_BANCAIRE                                       */
/*==============================================================*/
create table CARTE_BANCAIRE
(
   ID_MOYEN_PAIEMENT    int not null,
   DT_DEB_VALIDITE      date not null,
   DT_FIN_VALIDITE      date not null,
   ID_TYPE_CARTE        INT not null,
   NUMERO_CARTE         VARCHAR(30) not null,
   primary key (ID_MOYEN_PAIEMENT)
);

alter table CARTE_BANCAIRE comment 'Table des cartes bancaires associées aux comptes bancaires';

/*==============================================================*/
/* Table : CHEQUIER                                             */
/*==============================================================*/
create table CHEQUIER
(
   ID_MOYEN_PAIEMENT    INT not null,
   NOMBRE_CHQ           INT,
   NUMERO_1_CHQ         VARCHAR(30),
   NUMERO_D_CHQ         VARCHAR(30),
   primary key (ID_MOYEN_PAIEMENT)
);

alter table CHEQUIER comment 'Table des chéquiers associés aux comptes bancaires';

/*==============================================================*/
/* Table : CLIENT                                               */
/*==============================================================*/
create table CLIENT
(
   ID_CLIENT            INT not null auto_increment,
   NOM                  VARCHAR(100) not null,
   PRENOM               VARCHAR(40) not null,
   DT_NAISS             date not null,
   EMAIL                VARCHAR(100) not null,
   ADRESSE_PRINC        VARCHAR(100),
   ADRESSE_TEMP         VARCHAR(100),
   TEL_FIXE             VARCHAR(20),
   TEL_PORTABLE         VARCHAR(20),
   primary key (ID_CLIENT)
);

alter table CLIENT comment 'Table des clients ';

/*==============================================================*/
/* Table : COMPTE                                               */
/*==============================================================*/
create table COMPTE
(
   ID_COMPTE            INT not null auto_increment,
   DT_OUVERTURE         timestamp not null default CURRENT_TIMESTAMP,
   MONTANT_INITIAL      DECIMAL,
   ID_CLIENT            INT not null,
   TYPE_COMPTE          VARCHAR(50) not null,
   primary key (ID_COMPTE)
);

alter table COMPTE comment 'Table des comptes bancaires des clients';

/*==============================================================*/
/* Table : CONTRAT                                              */
/*==============================================================*/
create table CONTRAT
(
   ID_CONTRAT           INT not null auto_increment,
   DT_SOUS              timestamp not null default CURRENT_TIMESTAMP,
   INTITULE             VARCHAR(100),
   ID_CLIENT            INT not null,
   ID_PRODUIT           INT not null,
   ID_COMPTE            INT not null,
   STATUT_JUR           VARCHAR(30) not null,
   TYPE                 VARCHAR(30) not null,
   primary key (ID_CONTRAT)
);

alter table CONTRAT comment 'Table des contrats souscrits par des clients';

/*==============================================================*/
/* Table : CONTRAT_CREDIT                                       */
/*==============================================================*/
create table CONTRAT_CREDIT
(
   ID_CONTRAT           INT not null,
   OBJ_CREDIT           VARCHAR(100),
   DT_ECHEANCE          date not null,
   DUREE                INT not null,
   TAUX                 DECIMAL,
   MNT_CREDIT           DECIMAL not null,
   DT_PROC_ECHANCE      date,
   MNT_ECHEANCE         DECIMAL,
   TAUX_NOMINAL         DECIMAL,
   ENCOURS              DECIMAL,
   primary key (ID_CONTRAT)
);

alter table CONTRAT_CREDIT comment 'Table des crédits souscrits par des clients';

/*==============================================================*/
/* Table : CONTRAT_EPARGNE                                      */
/*==============================================================*/
create table CONTRAT_EPARGNE
(
   ID_CONTRAT           INT not null,
   TYPE_EPARGNE         VARCHAR(30) not null,
   TYPE_VERSEMENT       VARCHAR(30) not null,
   PERIODICITE          VARCHAR(30),
   DT_VERSEMENT         date,
   MNT_VERSE            DECIMAL not null,
   primary key (ID_CONTRAT)
);

alter table CONTRAT_EPARGNE comment 'Table des contrats sur produits épargne souscrits par des cl';

/*==============================================================*/
/* Table : HISTO_ETUDIANT                                       */
/*==============================================================*/
create table HISTO_ETUDIANT
(
   ID_HISTO_ETUDIANT    INT not null auto_increment,
   ANNEE_ACADEMIQUE     VARCHAR(9) not null,
   DIPLOME_PREPA        VARCHAR(30),
   NIVEAU_ETUDE         VARCHAR(30),
   NUMERO_CLI           INT not null,
   primary key (ID_HISTO_ETUDIANT)
);

alter table HISTO_ETUDIANT comment 'Table d''historiques pour un client étudiant';

/*==============================================================*/
/* Table : MOYEN_PAIEMENT                                       */
/*==============================================================*/
create table MOYEN_PAIEMENT
(
   ID_MOYEN_PAIEMENT    INT not null auto_increment,
   ID_COMPTE            INT,
   LIBELLE_MOYEN_PAIEMENT VARCHAR(30) not null,
   primary key (ID_MOYEN_PAIEMENT)
);

/*==============================================================*/
/* Table : OPERATION                                            */
/*==============================================================*/
create table OPERATION
(
   ID_OPERATION         INT not null auto_increment,
   ID_MOYEN_PAIEMENT    INT not null,
   ID_COMPTE			INT not null,
   LIBELLE              VARCHAR(100) not null,
   DT_COMPTABLE         timestamp NULL default NULL,
   DT_OPERATION         timestamp not null default CURRENT_TIMESTAMP,
   DT_VALEUR            timestamp NULL default NULL,
   MNT_DEBIT            DECIMAL,
   MNT_CREDIT           DECIMAL,
   STATUT               VARCHAR(30) not null,
   primary key (ID_OPERATION)
);

alter table OPERATION comment 'Table des transactions effectuées sur un compte';

/*==============================================================*/
/* Table : PRODUIT                                              */
/*==============================================================*/
create table PRODUIT
(
   ID_PRODUIT           INT not null auto_increment,
   LIBELLE_PRODUIT      VARCHAR(100) not null,
   primary key (ID_PRODUIT)
);

alter table PRODUIT comment 'Référentiel des produits commercialisés';

/*==============================================================*/
/* Table : TYPE_CARTE                                           */
/*==============================================================*/
create table TYPE_CARTE
(
   ID_TYPE_CARTE        INT not null auto_increment,
   RESEAU               VARCHAR(50),
   PLF_GLO_PAIE         DECIMAL,
   PLF_GLO_PAIE_ETRG    DECIMAL,
   PERI_PLF_PAIE        INT,
   PLF_GLO_RET_EXT      DECIMAL,
   PLF_RET_ETRG         DECIMAL,
   PLF_RET_FCE          DECIMAL,
   PERI_PLF_GLO_RET     INT,
   PLF_GLO_RET_INT      DECIMAL,
   primary key (ID_TYPE_CARTE)
);

alter table TYPE_CARTE comment 'Référentiel des type de carte';

alter table CARTE_BANCAIRE add constraint FK_REFERENCE_1 foreign key (ID_TYPE_CARTE)
      references TYPE_CARTE (ID_TYPE_CARTE) on delete restrict on update restrict;

alter table CARTE_BANCAIRE add constraint FK_REFERENCE_15 foreign key (ID_MOYEN_PAIEMENT)
      references MOYEN_PAIEMENT (ID_MOYEN_PAIEMENT) on delete restrict on update restrict;

alter table CHEQUIER add constraint FK_REFERENCE_11 foreign key (ID_MOYEN_PAIEMENT)
      references MOYEN_PAIEMENT (ID_MOYEN_PAIEMENT) on delete restrict on update restrict;

alter table COMPTE add constraint FK_REFERENCE_3 foreign key (ID_CLIENT)
      references CLIENT (ID_CLIENT) on delete restrict on update restrict;

alter table CONTRAT add constraint FK_REFERENCE_13 foreign key (ID_CLIENT)
      references CLIENT (ID_CLIENT) on delete restrict on update restrict;

alter table CONTRAT add constraint FK_REFERENCE_14 foreign key (ID_PRODUIT)
      references PRODUIT (ID_PRODUIT) on delete restrict on update restrict;

alter table CONTRAT add constraint FK_REFERENCE_17 foreign key (ID_COMPTE)
      references COMPTE (ID_COMPTE) on delete restrict on update restrict;

alter table CONTRAT_CREDIT add constraint FK_REFERENCE_16 foreign key (ID_CONTRAT)
      references CONTRAT (ID_CONTRAT) on delete restrict on update restrict;

alter table CONTRAT_EPARGNE add constraint FK_REFERENCE_12 foreign key (ID_CONTRAT)
      references CONTRAT (ID_CONTRAT) on delete restrict on update restrict;

alter table HISTO_ETUDIANT add constraint FK_REFERENCE_7 foreign key (NUMERO_CLI)
      references CLIENT (ID_CLIENT) on delete restrict on update restrict;

alter table MOYEN_PAIEMENT add constraint FK_REFERENCE_19 foreign key (ID_COMPTE)
      references COMPTE (ID_COMPTE) on delete restrict on update restrict;

alter table OPERATION add constraint FK_REFERENCE_18 foreign key (ID_COMPTE)
      references COMPTE (ID_COMPTE) on delete restrict on update restrict;

alter table OPERATION add constraint FK_REFERENCE_8 foreign key (ID_MOYEN_PAIEMENT)
      references MOYEN_PAIEMENT (ID_MOYEN_PAIEMENT) on delete restrict on update restrict;

drop procedure if exists addCarte;
CREATE PROCEDURE addCarte (IN ID_COMPTE int,IN LIBELLE_MOYEN_PAIEMENT VARCHAR(30), IN DT_DEB_VALIDITE date
							,IN DT_FIN_VALIDITE date,IN ID_TYPE_CARTE int
							, NUMERO_CARTE varchar(30),OUT error varchar(50))
main:BEGIN

if LIBELLE_MOYEN_PAIEMENT is null then
	set error='Le moyen de paiement est null';
	leave main;
end if;
if ID_COMPTE is null then
	set error='Le compte est null';
	leave main;
end if;

INSERT INTO MOYEN_PAIEMENT (ID_COMPTE,LIBELLE_MOYEN_PAIEMENT) values(ID_COMPTE,LIBELLE_MOYEN_PAIEMENT);
set @id = LAST_INSERT_ID();
INSERT INTO CARTE_BANCAIRE values(@id,DT_DEB_VALIDITE,DT_FIN_VALIDITE,ID_TYPE_CARTE,NUMERO_CARTE);

leave main;
END;

drop procedure if exists addChequier;
CREATE PROCEDURE addChequier (IN ID_COMPTE int,IN LIBELLE_MOYEN_PAIEMENT VARCHAR(30)
							,IN NOMBRE_CHQ int,IN NUMERO_1_CHQ varchar(30)
							,IN NUMERO_D_CHQ varchar(30),OUT error varchar(50))
main:BEGIN

if LIBELLE_MOYEN_PAIEMENT is null then
	set error='Le moyen de paiement est null';
	leave main;
end if;
if ID_COMPTE is null then
	set error='Le compte est null';
	leave main;
end if;

INSERT INTO MOYEN_PAIEMENT (ID_COMPTE,LIBELLE_MOYEN_PAIEMENT) values(ID_COMPTE,LIBELLE_MOYEN_PAIEMENT);
set @id = LAST_INSERT_ID();
INSERT INTO CHEQUIER values(@id,NOMBRE_CHQ,NUMERO_1_CHQ,NUMERO_D_CHQ);

leave main;
END;

drop procedure if exists delChequier;
CREATE PROCEDURE delChequier (IN ID_MOYEN_PAIEMENT int)
BEGIN
DELETE FROM CHEQUIER WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
DELETE FROM MOYEN_PAIEMENT WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
END;

drop procedure if exists delCarte;
CREATE PROCEDURE delCarte (IN ID_MOYEN_PAIEMENT int)
BEGIN
DELETE FROM CARTE WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
DELETE FROM MOYEN_PAIEMENT WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
END;

drop procedure if exists delMoyenPaiement;
CREATE PROCEDURE delMoyenPaiement (IN ID_MOYEN_PAIEMENT int)
BEGIN
DELETE FROM CHEQUIER WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
DELETE FROM CARTE WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
DELETE FROM MOYEN_PAIEMENT WHERE ID_MOYEN_PAIEMENT=ID_MOYEN_PAIEMENT;
END;

drop procedure if exists addContratEpargne;
CREATE PROCEDURE addContratEpargne (IN INTITULE VARCHAR(100), IN ID_CLIENT INT,IN ID_PRODUIT INT,
IN ID_COMPTE INT, IN STATUT_JUR VARCHAR(30), IN TYPE  VARCHAR(30), IN TYPE_EPARGNE VARCHAR(30),
IN TYPE_VERSEMENT VARCHAR(30), IN PERIODICITE VARCHAR(30), IN DT_VERSEMENT date, IN MNT_VERSE DECIMAL,
OUT error varchar(50))
BEGIN

INSERT INTO CONTRAT (INTITULE,ID_CLIENT,ID_PRODUIT,ID_COMPTE,STATUT_JUR,TYPE)
values(INTITULE,ID_CLIENT,ID_PRODUIT,ID_COMPTE,STATUT_JUR,TYPE);
set @id = LAST_INSERT_ID();
INSERT INTO CONTRAT_EPARGNE values(@id,TYPE_EPARGNE,TYPE_VERSEMENT,PERIODICITE,DT_VERSEMENT,MNT_VERSE);

END;

drop procedure if exists delContratEpargne;
CREATE PROCEDURE delContratEpargne (IN ID_CONTRAT int)
BEGIN
DELETE FROM CONTRAT_EPARGNE WHERE ID_CONTRAT=ID_CONTRAT;
DELETE FROM CONTRAT WHERE ID_CONTRAT=ID_CONTRAT;
END;

drop procedure if exists delContratCredit;
CREATE PROCEDURE delContratCredit (IN ID_CONTRAT int)
BEGIN
DELETE FROM CONTRAT_CREDIT WHERE ID_CONTRAT=ID_CONTRAT;
DELETE FROM CONTRAT WHERE ID_CONTRAT=ID_CONTRAT;
END;

drop procedure if exists delContrat;
CREATE PROCEDURE delContrat (IN ID_CONTRAT int)
BEGIN
DELETE FROM CONTRAT_EPARGNE WHERE ID_CONTRAT=ID_CONTRAT;
DELETE FROM CONTRAT_CREDIT WHERE ID_CONTRAT=ID_CONTRAT;
DELETE FROM CONTRAT WHERE ID_CONTRAT=ID_CONTRAT;
END;

drop procedure if exists addContratCredit;
CREATE PROCEDURE addContratCredit (IN INTITULE VARCHAR(100), IN ID_CLIENT INT,IN ID_PRODUIT INT,
IN ID_COMPTE INT, IN STATUT_JUR VARCHAR(30), IN TYPE VARCHAR(30), IN OBJ_CREDIT VARCHAR(100),
IN DT_ECHEANCE date, IN DUREE INT, IN TAUX DECIMAL, IN MNT_CREDIT DECIMAL, IN DT_PROC_ECHANCE date,
IN MNT_ECHEANCE DECIMAL, IN TAUX_NOMINAL DECIMAL, IN ENCOURS DECIMAL, OUT error varchar(50))
BEGIN

INSERT INTO CONTRAT (INTITULE,ID_CLIENT,ID_COMPTE,STATUT_JUR,TYPE)
values(INTITULE,ID_CLIENT,ID_COMPTE,STATUT_JUR,TYPE);
set @id = LAST_INSERT_ID();
INSERT INTO CONTRAT_CREDIT values(@id,OBJ_CREDIT,DT_ECHEANCE,DUREE,TAUX,MNT_CREDIT,DT_PROC_ECHANCE,
MNT_ECHEANCE,TAUX_NOMINAL,ENCOURS);

END;