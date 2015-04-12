INSERT INTO `TYPE_CARTE` (`ID_TYPE_CARTE`, `RESEAU`, `PLF_GLO_PAIE`, `PLF_GLO_PAIE_ETRG`, `PERI_PLF_PAIE`, `PLF_GLO_RET_EXT`, `PLF_RET_ETRG`, `PLF_RET_FCE`, `PERI_PLF_GLO_RET`, `PLF_GLO_RET_INT`) VALUES
(1, 'VISA', '1000', '700', 14, '300', '300', '500', 7, '500'),
(2, 'VISA', '2000', '1400', 14, '600', '600', '600', 7, '1000'),
(3, 'MASTERCARD', '2000', '1400', 14, '600', '600', '600', 7, '1000'),
(4, 'MASTERCARD', '1000', '700', 14, '500', '500', '600', 7, '700');

INSERT INTO `CLIENT` (`ID_CLIENT`, `NOM`, `PRENOM`, `DT_NAISS`, `EMAIL`, `ADRESSE_PRINC`, `ADRESSE_TEMP`, `TEL_FIXE`, `TEL_PORTABLE`) VALUES
(1, 'Tiganu', 'Eugen', '1989-08-29 00:00:00', 'eugen.tiganu@gmail.com', '5 Rue de Reims 75013 Paris', NULL, NULL, '0676112039'),
(2, 'Lestic', 'Florian', '1992-04-06 00:00:00', 'lestic.florian@gmail.com', 'Paris', NULL, NULL, '0635965468');

INSERT INTO `COMPTE` (`ID_COMPTE`, `DT_OUVERTURE`, `MONTANT_INITIAL`, `ID_CLIENT`, `TYPE_COMPTE`) VALUES
(1, '2015-04-07 16:12:08', '20', 1, 'Courant'),
(2, '2015-04-07 16:12:08', '100', 1, 'Epargne'),
(3, '2015-04-07 16:12:08', '50', 2, 'Courant'),
(4, '2015-04-07 16:12:08', '200', 1, 'Epargne');

INSERT INTO `MOYEN_PAIEMENT` (`ID_MOYEN_PAIEMENT`, `ID_COMPTE`, `LIBELLE_MOYEN_PAIEMENT`) VALUES
(1, 1, 'Carte de credit'),
(2, 2, 'Chequier');

INSERT INTO `CARTE_BANCAIRE` (`ID_MOYEN_PAIEMENT`, `DT_DEB_VALIDITE`, `DT_FIN_VALIDITE`, `ID_TYPE_CARTE`, `NUMERO_CARTE`) VALUES
(1, '2015-04-08 00:00:00', '2017-04-07 00:00:00', 1, '1234 1234 1234 1234');

INSERT INTO `CHEQUIER` (`ID_MOYEN_PAIEMENT`, `NOMBRE_CHQ`, `NUMERO_1_CHQ`, `NUMERO_D_CHQ`) VALUES
(2, 20, '123456', '123476');

INSERT INTO `etrade_csharp`.`OPERATION` (`ID_OPERATION`, `ID_MOYEN_PAIEMENT`, `ID_COMPTE`, `LIBELLE`, `DT_COMPTABLE`, `DT_OPERATION`, `DT_VALEUR`, `MNT_DEBIT`, `MNT_CREDIT`, `STATUT`) VALUES 
(NULL, '1', '1', 'Alimentation', NULL, CURRENT_TIMESTAMP, NULL, NULL, 200, 'Realise'), 
(NULL, '1', '1', 'Achat livre', NULL, CURRENT_TIMESTAMP, NULL, '10', NULL, 'Realise'), 
(NULL, '1', '1', 'Cinema', NULL, CURRENT_TIMESTAMP, NULL, '15', NULL, 'Realise'), 
(NULL, '1', '1', 'Alimentation', NULL, CURRENT_TIMESTAMP, NULL, NULL, 50, 'Realise'), 
(NULL, '2', '1', 'Achat PC', NULL, CURRENT_TIMESTAMP, NULL, '25', NULL, 'Realise'), 
(NULL, '2', '1', 'Achat Calc', NULL, CURRENT_TIMESTAMP, NULL, '30', NULL, 'Realise'),
(NULL, NULL, '2', 'Alimentation', NULL, CURRENT_TIMESTAMP, NULL, NULL, 200, 'Realise'),
(NULL, NULL, '2', 'Virement', NULL, CURRENT_TIMESTAMP, NULL, '50', NULL, 'Realise'), 
(NULL, NULL, '2', 'Alimentation', NULL, CURRENT_TIMESTAMP, NULL, NULL, 50, 'Realise'), 
(NULL, NULL, '2', 'Virement', NULL, CURRENT_TIMESTAMP, NULL, '25', NULL, 'Realise');