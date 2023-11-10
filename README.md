## 1 - DESCRIPTION DE L’ENTREPRISE MENAGELEC.

L’entreprise MENAGELEC est une SARL créée par deux techniciens de l’électroménager, M FOURNIER
Michel et M HURIER Alain. Elle se situe dans le secteur « Dépannage et entretien des appareils 
domestiques ». Leurs compétences variées et complémentaires (dépannage des particuliers et des 
professionnels, connaissances techniques pointues, développement informatique « amateur », 
techniques mercatiques et managériales…) ainsi que leur forte implication dans l’entreprise a permis de 
développer la branche commerciale de l’entreprise. Il s’agit de vendre des pièces détachées par le biais 
de partenaires externes (les SAV de grands groupes comme Darty, But, Carrefour,…) et de plateformes 
« internet » à l’image du Marketplace d’Amazon. Forte de ses nombreux clients, l’entreprise a investi 
dans plusieurs hangars afin de stocker les pièces.


## 2 - REORGANISATION

L’activité de vente de pièces détachées pour appareils électroménagers continue de progresser 
fortement. Pratiquement aucun outil n’est utilisé par les deux associés pour gérer les produits du 
catalogue car c’était avant tout une tentative qui a fonctionné tout de suite. Il n’est plus possible de 
développer davantage l’entreprise sans une analyse des processus supports (approvisionnement, gestion 
des stocks, facturation, colisage, expédition, SAV, mise au catalogue,…). Cela freine également 
l’embauche de personnel nécessaire alors que l’entreprise a les moyens de financer deux employés.


## 3 - ANALYSE DE L’EXISTANT

S’il existe un site e-commerce pour la vente des produits en ligne, il n’y a aucun suivi possible des 
commandes passées par l’intermédiaire de celui-ci. Les associés n’ont aucun processus automatisé qui 
leur permettrait de savoir quelles commandes sont payées, voire expédiées. Du coup, il est également 
impossible de générer automatiquement la liste de colisage. Toutes ces opérations sont actuellement 
réalisées manuellement.


## 4 - BESOINS D’EVOLUTION

M Fournier a besoin d’un logiciel qui lui permette de gérer la paiement des commandes et les 
expéditions correspondantes. 
Règles de gestion
Une commande ne concerne qu’un seul client
Une commande non payée ne peut pas être expédiée


## 5 - RESSOURCES UTILES AU PROJET

Les ressources sont situées dans le dossier « PPE2 » dans le dossier des ressources habituelles.
Ce dossier contient :
- La base de données : menageleccsharp
- Les images de l’interface graphique
- Les images des produits : dossier « imagesProduit »


## 6 - CAHIER DES CHARGES

- La phase d’analyse doit conduire à l’élaboration d’une documentation (diagramme de classes par 
exemple) suffisamment détaillée qui permettra une consultation ultérieure dans le cadre d’une 
maintenance corrective ou évolutive.
- L’implémentation de l’application doit respecter le diagramme de classes élaboré durant la 
phase d’analyse. 
- Le logiciel doit être un client lourd (couche interface homme machine et couche métier dans la 
même application). La couche d’accès aux données utilisera le SGBR Mysql
- Le langage C# est le langage retenu pour développer l’application
- L’IDE utilisé est visual studio (version express suffisante)
- La base de données à mettre en œuvre est la base de données du site e-commerce (Base Mysql
« menageleccsharp.sql »)
- L’application sera développée en Windows Form.
- chaque membre utilise son poste en tant que serveur Mysql (pas de partage de la base de 
données)
- les images propres à l’interface de gestion doivent être portées avec l’application (ex : un bouton 
vert)
- la génération de fichiers PDF sera mise en place avec la classe itextsharp

  
## 7 - ANALYSE FONCTIONNELLE
  
Voici les fonctionnalités à développer organisées par module.
Pour une meilleure compréhension, vous pouvez en parallèle prendre connaissance de la partie 
« Interface graphique » abordée plus loin dans ce support.

Accès à l’application
- L’application doit être accessible après vérification d’un login et d’un mot de passe
- Les utilisateurs de l’application seront 
o M Fournier : couple login/mot de passe : fournier/1234
o M Hurier : couple login/mot de passe : hurier/5678
- Les utilisateurs de l’application ne seront pas stockés dans une base de données (authentification 
en « dur »)
- Le succès de l’authentification doit afficher un menu
  
Menu
Le menu doit proposer un accès au module de « Gestion des commandes »

Gestion des commandes
- Au chargement de ce formulaire :
o La liste de toutes les commandes doit s’afficher
o La 1ère commande de la liste doit être affichée
o Les informations liées à cette commandes doivent s’afficher (donc les informations  client, commande et contenu commande). Le nombre d’articles dans la colonne doit apparaître.
Affichage de la liste des commandes
La liste des commandes doit afficher le numéro de commande, sa date et l’identifiant client ayant passé 
la commande.

Filtrage des commandes

L’affichage des commandes doit proposer trois filtres :
 Tout (pour toutes les commandes)
 A payer (pour les commandes non encore payées)
 A expédier (pour les commandes payées mais pas encore expédiées)
Un filtre est sélectionné en cochant la case correspondante.

Sélection d’une commande
Quel que soit le filtre sélectionné, la sélection d’une commande se fait en cliquant sur son numéro ou sur le numéro de client correspondant.

Cela a pour effet :
- d’afficher les informations du client qui a passé la commande
- d’afficher les informations de la commande
- d’afficher le contenu de la commande (identifiant du produit et quantité dans la commande)

Remarque : si la sélection d’une commande a lieu en cliquant sur le numéro de client, c’est bien la cellule 
contenant le numéro de commande qui doit apparaître comme cellule sélectionnée.

Recherche spécifique
Une recherche spécifique sur le numéro de client ou le numéro de commande doit conduire à un affichage des commandes concernées avec le filtre « Tout »
La validation d’une recherche spécifique se fait par le biais d’une case à cocher.
Lorsque la recherche porte sur un client, le champ de recherche doit être mis en surbrillance et les 
informations du client doivent montrer qu’il s’agit d’une recherche spécifique. La recherche d’un numéro de commande doit se comporter de façon identique.
Un clic dans une zone de recherche (numéro de client ou numéro de commande) doit conduire à désactiver une recherche spécifique en cours (affichée) et par conséquent afficher toutes les commandes.
Attention : les filtres « Tout » « A payer » et « A expédier » doivent être utilisables avec une recherche spécifique.


Gestion des paiements et des expéditions
Une commande à payer doit pouvoir être marquée comme payée.
Une commande expédiée doit pouvoir être marquée comme expédiée
Le passage de l’état « commande à payer » à « commande à expédier » doit activer le filtre 
correspondant :
Dans la liste des commandes « A payer », choisir une commande. Pour cette commande, marquer la 
commande comme payée. A cet instant, la liste des commandes « A expédier » s’affiche et la commande 
qui vient d’être payée doit être sélectionnée par défaut.
Le passage de l’état « commande à expédier » à « commande expédiée » doit activer le filtre « Tout ». 
Pour une commande, marquer la commande comme expédiée. A cet instant, la liste de toutes les 
commandes s’affiche et la commande qui vient d’être expédiée doit être sélectionnée par défaut.
Fiche produit
Dans le contenu de la commande, un clic sur l’identifiant du produit doit afficher une nouvelle fenêtre
modale. Cette fenêtre donne accès à la désignation du produit, sa photo, sa description et son prix. 
Lorsqu’un produit n’a pas de description, il faudra afficher le message « aucune description pour ce 
produit ».
Documents
Une liste de colisage doit être générée automatique à la demande (voir une liste de colisage dans les 
annexes). Dès que la liste est générée au format PDF, elle est automatiquement ouverte.
Retour au menu
Un bouton doit permettre de fermer le formulaire de Gestion des commandes pour retourner au menu.
Fonctionnalité non visible
Des statistiques doivent être stockées en base de données.
Ainsi, une table « statistiques » doit contenir le nombre de commandes à expédier. Ce nombre devra 
être mis à jour via un trigger. Lorsqu’une commande a été payée, le nombre de commandes à expédier 
doit être incrémenté. Lorsqu’une commande a été expédiée, le nombre de commandes à expédier doit 
être décrémenté.


## 8 - TEST DE L’APPLICATION

Une fiche de tests unitaires doit être réalisée au fur et à mesure du développement. Une fonctionnalité 
est créée, vous prévoyez un test sur la fiche de test. Ainsi, une fois votre projet terminé, tous les tests 
figureront sur la fiche. Ce document est indispensable pour les CCF.


## 9 - COMPETENCES MOBILISEES

 La réalisation de ce projet doit permettre de couvrir au minimum les compétences suivantes 
(c’est indispensable pour le CCF de fin d’année)
o Scripting C# en utilisant l’IDE Visual Studio (version Express suffisante)
o Programmation événementielle
o Ajout de références à un projet et intégration pour assurer la portabilité de l’application
o liaison d’une application c# avec une base de données Mysql
o réalisation de classes métiers
o réalisation de formulaires (Win Form)
o utilisation de composant de formulaire non liés à une base de données
o utilisation de composants de formulaire liés à la base de données (ex : combo box, 
datagridview,…)
o interaction avec une base de données Mysql
o toutes opérations portant sur la structure d’une table (ajout d’un champ, modification 
de son nom, de son type, etc)
o toutes opérations portant sur la lecture d’une table (SELECT…)
o toutes opérations de modifications, insertions, suppression sur les données d’une table
o réalisation de triggers
o réalisation de procédures stockées et exploitation
o réalisation d’une fiche de tests unitaires


## 10 - LIVRABLE

La solution à livrer au client doit être totalement intégrée et pleinement fonctionnelle (condition 
obligatoire pour le CCF)


## 11 - AIDE ORGANISATIONNELLE POUR LA REALISATION DU PROJET

Voici quelques conseils que je vous invite fortement à suivre pour être plus efficace.
Ne tentez pas de tout réaliser. Il faut découper les différents éléments d’un même formulaire lorsqu’ils 
sont nombreux.
Etapes de réalisation :
 Rechercher comment utiliser une bdd Mysql avec C# (nous utiliserons la connexion en dur, c'està-dire codée par nous même sans utiliser le gestionnaire de connexion) => cela permet d’assurer 
la compatibilité du projet avec Visual studio express.
 Formulaire de connexion (fiche de tests unitaires)
 Menu (fiche de tests unitaires)
 Gestion des commandes (réaliser les éléments numérotés (voir interface graphique) dans l’ordre 
de leur numérotation.) (fiche de tests unitaires à alimenter après chaque fonctionnalité ajoutée)


## 12 - CHARTE GRAPHIQUE

Police utilisée : Microsoft Sans Serif; 14,25pt

Taille de police :
- Titre de formulaire : 14,25pt
- Nom des rubriques (Liste des commandes, Recherche spécifiques,…) : 12pt
- Autres éléments textuels : 8,25pt
  
Titres, nom des rubriques, autres éléments textuels : blanc
Couleur de fond : utiliser l’élément « background.png » du dossier « «imagesInterfaceGraphique »


## 13 - INTERFACE GRAPHIQUE

Eléments communs à toutes les fenêtres
Le logo doit apparaître dans toutes les fenêtres à gauche de la barre de titre.
Les fenêtres ne doivent pas être redimensionnables
