/*==============================================================*/
/* Nom de SGBD :  MySQL 5.0                                     */
/* Date de création :  07/04/2015 18:24:16                      */
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
/* Table : TYPE_CARTE                                           */
/*==============================================================*/
create table TYPE_CARTE
(
   CODE_TYPE_CARTE      INT not null auto_increment,
   LIBELLE_TYPE_CRATE   VARCHAR(50),
   PLF_GLO_PAIE         DECIMAL,
   PLF_GLO_PAIE_ETRG    DECIMAL,
   PERI_PLF_PAIE        INT,
   PLF_GLO_RET_EXT      DECIMAL,
   PLF_RET_ETRG         DECIMAL,
   PLF_RET_FCE          DECIMAL,
   PERI_PLF_GLO_RET     INT,
   PLF_GLO_RET_INT      DECIMAL,
   primary key (CODE_TYPE_CARTE)
);

alter table TYPE_CARTE comment 'Référentiel des type de carte';

/*==============================================================*/
/* Table : CARTE_BANCAIRE                                       */
/*==============================================================*/
create table CARTE_BANCAIRE
(
   CODE_CARTE           int not null,
   DT_DEB_VALIDITE      timestamp not null,
   DT_FIN_VALIDITE      timestamp not null,
   RESEAU_CARTE         VARCHAR(10) not null,
   CODE_TYPE_CARTE      INT not null,
   NUMERO_CARTE         VARCHAR(30) not null,
   primary key (CODE_CARTE),
   constraint FK_REFERENCE_1 foreign key (CODE_TYPE_CARTE)
      references TYPE_CARTE (CODE_TYPE_CARTE) on delete restrict on update restrict
);

alter table CARTE_BANCAIRE comment 'Table des cartes bancaires associées aux comptes bancaires';

/*==============================================================*/
/* Table : CHEQUIER                                             */
/*==============================================================*/
create table CHEQUIER
(
   NUMERO_CHQ           INT not null,
   NOMBRE_CHQ           INT,
   NUMERO_1_CHQ         VARCHAR(30),
   NUMERO_D_CHQ         VARCHAR(30),
   primary key (NUMERO_CHQ)
);

alter table CHEQUIER comment 'Table des chéquiers associés aux comptes bancaires';

/*==============================================================*/
/* Table : CLIENT                                               */
/*==============================================================*/
create table CLIENT
(
   NUMERO_CLI           INT not null auto_increment,
   NOM                  VARCHAR(100) not null,
   PRENOM               VARCHAR(40) not null,
   DT_NAISS             timestamp not null,
   EMAIL                VARCHAR(100) not null,
   ADRESSE_PRINC        VARCHAR(100),
   ADRESSE_TEMP         VARCHAR(100),
   TEL_FIXE             VARCHAR(20),
   TEL_PRTABLE          VARCHAR(20),
   primary key (NUMERO_CLI)
);

alter table CLIENT comment 'Table des clients ';

/*==============================================================*/
/* Table : MOYEN_PAIEMENT                                       */
/*==============================================================*/
create table MOYEN_PAIEMENT
(
   CODE_MOYEN_PAIEMENT  INT not null,
   LIBELLE_MOYEN_PAIEMENT VARCHAR(30) not null,
   primary key (CODE_MOYEN_PAIEMENT),
   constraint FK_REFERENCE_11 foreign key (CODE_MOYEN_PAIEMENT)
      references CHEQUIER (NUMERO_CHQ) on delete restrict on update restrict,
   constraint FK_REFERENCE_15 foreign key (CODE_MOYEN_PAIEMENT)
      references CARTE_BANCAIRE (CODE_CARTE) on delete restrict on update restrict
);

/*==============================================================*/
/* Table : COMPTE                                               */
/*==============================================================*/
create table COMPTE
(
   NUMERO_COMPTE        INT not null auto_increment,
   DT_OUVERTURE         timestamp not null default CURRENT_TIMESTAMP,
   MONTANT_INITIAL      DECIMAL,
   NUMERO_CLI           INT not null,
   CODE_MOYEN_PAIEMENT  INT,
   TYPE_COMPTE          VARCHAR(50) not null,
   primary key (NUMERO_COMPTE),
   constraint FK_REFERENCE_3 foreign key (NUMERO_CLI)
      references CLIENT (NUMERO_CLI) on delete restrict on update restrict,
   constraint FK_REFERENCE_10 foreign key (CODE_MOYEN_PAIEMENT)
      references MOYEN_PAIEMENT (CODE_MOYEN_PAIEMENT) on delete restrict on update restrict
);

alter table COMPTE comment 'Table des comptes bancaires des clients';

/*==============================================================*/
/* Table : PRODUIT                                              */
/*==============================================================*/
create table PRODUIT
(
   CODE_PRODUIT         INT not null auto_increment,
   LIBELLE_PRODUIT      VARCHAR(100) not null,
   primary key (CODE_PRODUIT)
);

alter table PRODUIT comment 'Référentiel des produits commercialisés';

/*==============================================================*/
/* Table : CONTRAT_EPARGNE                                      */
/*==============================================================*/
create table CONTRAT_EPARGNE
(
   NUMERO_CTR           INT not null,
   TYPE_EPARGNE         VARCHAR(30),
   TYPE_VERSEMENT       VARCHAR(30),
   PERIODICITE          VARCHAR(30),
   DT_VERSEMENT         timestamp,
   MNT_VERSE            DECIMAL not null,
   primary key (NUMERO_CTR)
);

alter table CONTRAT_EPARGNE comment 'Table des contrats sur produits épargne souscrits par des cl';

/*==============================================================*/
/* Table : CONTRAT_CREDIT                                       */
/*==============================================================*/
create table CONTRAT_CREDIT
(
   NUMERO_CTR           INT not null,
   OBJ_CREDIT           VARCHAR(100),
   DT_ECHEANCE          timestamp not null,
   DUREE                INT not null,
   TAUX                 DECIMAL,
   MNT_CREDIT           DECIMAL not null,
   DT_PROC_ECHANCE      timestamp,
   MNT_ECHEANCE         DECIMAL,
   TAUX_NOMINAL         DECIMAL,
   ENCOURS              DECIMAL,
   primary key (NUMERO_CTR)
);

alter table CONTRAT_CREDIT comment 'Table des crédits souscrits par des clients';

/*==============================================================*/
/* Table : CONTRAT                                              */
/*==============================================================*/
create table CONTRAT
(
   NUMERO_CTR           INT not null,
   DT_SOUS              timestamp not null default CURRENT_TIMESTAMP,
   INTITULE             VARCHAR(100),
   NUMERO_CLI           INT not null,
   CODE_PRODUIT         INT not null,
   NUMERO_COMPTE        INT not null,
   STATUT_JUR           VARCHAR(30) not null,
   TYPE                 VARCHAR(30) not null,
   primary key (NUMERO_CTR),
   constraint FK_REFERENCE_13 foreign key (NUMERO_CLI)
      references CLIENT (NUMERO_CLI) on delete restrict on update restrict,
   constraint FK_REFERENCE_14 foreign key (CODE_PRODUIT)
      references PRODUIT (CODE_PRODUIT) on delete restrict on update restrict,
   constraint FK_REFERENCE_12 foreign key (NUMERO_CTR)
      references CONTRAT_EPARGNE (NUMERO_CTR) on delete restrict on update restrict,
   constraint FK_REFERENCE_16 foreign key (NUMERO_CTR)
      references CONTRAT_CREDIT (NUMERO_CTR) on delete restrict on update restrict,
   constraint FK_REFERENCE_17 foreign key (NUMERO_COMPTE)
      references COMPTE (NUMERO_COMPTE) on delete restrict on update restrict
);

alter table CONTRAT comment 'Table des contrats souscrits par des clients';

/*==============================================================*/
/* Table : HISTO_ETUDIANT                                       */
/*==============================================================*/
create table HISTO_ETUDIANT
(
   REFERENCE_HISTO      INT not null auto_increment,
   ANNEE_ACADEMIQUE     VARCHAR(9) not null,
   DIPLOME_PREPA        VARCHAR(30),
   NIVEAU_ETUDE         VARCHAR(30),
   NUMERO_CLI           INT not null,
   primary key (REFERENCE_HISTO),
   constraint FK_REFERENCE_7 foreign key (NUMERO_CLI)
      references CLIENT (NUMERO_CLI) on delete restrict on update restrict
);

alter table HISTO_ETUDIANT comment 'Table d''historiques pour un client étudiant';

/*==============================================================*/
/* Table : OPERATION                                            */
/*==============================================================*/
create table OPERATION
(
   REFERENCE            INT not null auto_increment,
   CODE_MOYEN_PAIEMENT  INT not null,
   LIBELLE              VARCHAR(100) not null,
   TYPE_OPERATION       VARCHAR(30) not null,
   DT_COMPTABLE         timestamp default CURRENT_TIMESTAMP,
   DT_OPERATION         timestamp not null,
   DT_VALEUR            timestamp,
   MNT_DEBIT            DECIMAL,
   MNT_CREDIT           DECIMAL,
   STATUT               VARCHAR(30) not null,
   primary key (REFERENCE),
   constraint FK_REFERENCE_8 foreign key (CODE_MOYEN_PAIEMENT)
      references MOYEN_PAIEMENT (CODE_MOYEN_PAIEMENT) on delete restrict on update restrict
);

alter table OPERATION comment 'Table des transactions effectuées sur un compte';