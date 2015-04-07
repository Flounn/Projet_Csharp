/*==============================================================*/
/* Nom de SGBD :  MySQL 5.0                                     */
/* Date de création :  08/04/2015 00:28:57                      */
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
   DT_DEB_VALIDITE      datetime not null,
   DT_FIN_VALIDITE      datetime not null,
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
   DT_NAISS             datetime not null,
   EMAIL                VARCHAR(100) not null,
   ADRESSE_PRINC        VARCHAR(100),
   ADRESSE_TEMP         VARCHAR(100),
   TEL_FIXE             VARCHAR(20),
   TEL_PRTABLE          VARCHAR(20),
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
   ID_MOYEN_PAIEMENT    INT,
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
   DT_ECHEANCE          datetime not null,
   DUREE                INT not null,
   TAUX                 DECIMAL,
   MNT_CREDIT           DECIMAL not null,
   DT_PROC_ECHANCE      datetime,
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
   DT_VERSEMENT         datetime,
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
   LIBELLE              VARCHAR(100) not null,
   TYPE_OPERATION       VARCHAR(30) not null,
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

alter table COMPTE add constraint FK_REFERENCE_10 foreign key (ID_MOYEN_PAIEMENT)
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

alter table OPERATION add constraint FK_REFERENCE_8 foreign key (ID_MOYEN_PAIEMENT)
      references MOYEN_PAIEMENT (ID_MOYEN_PAIEMENT) on delete restrict on update restrict;

