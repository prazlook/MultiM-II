***Mise à jour!***
Le code source est maintenant fourni et exécutable avec SoftwareZator 2014 (SoftwareZator 4).
Comme SoftwareZator n'est plus installable,vous trouverez une VM avec le logiciel stable dessus dans mes autres dépôts.
Pour télécharger la version compilée du logiciel, allez dans les versions (Releases).

MultiM II est un logiciel supposé tourner
sur tous les OS à partir de Windows 7.
Il s'agit d'un logiciel qui aura, dans sa
version finale et fonctionnelle, la capacité 
de permettre à l'utilisateur de créer son 
propre serveur Minitel entièrement personnalisable
avec notamment des fonctionnalités de haut 
débit et d'utilisation du LECAM.Il est
également compatible avec les fonctionnalités 
"Annuaire direct" et "Messagerie directe" du
Minitel 12.
Vous n'avez RIEN besoin de connaître en code
pour utiliser ce logiciel.L'interface 
utilisateur, bien qu'un peu chargée,
est conçue pour être très intuitive,
simple et facile d'utilisation.
Bugs connus:
-Ne fermez pas la fenêtre de démarrage avec
la barre verte.Ça vaut mieux pour tout le monde.
-N'acceptez en aucun cas une invite
qui vous propose de réparer des erreurs.
-N'essayez pas de vous connecter.Surtout 
pas.
Système de sauvegarde et d'exportation :
Vous devez d'abord exporter un fichier 
*.arb de ArboEdit qui sera l'arborescence
de votre serveur, c'est-à-dire quelles 
pages peuvent être consultés par qui
et à partir d'où.
Ensuite, vous devez l'importer dans Compistart,
qui est le logiciel clé de la suite et
aussi votre panneau de commande.Vous
pouvez choisir parmi des centaines d'options 
diverses pour configurer votre serveur !
Ne vous inquiétez pas s'il y a une option 
qui vous manque, contactez-moi et ce sera
vite résolu !
Pour finir,vous devez compiler votre serveur
(après l'avoir branché si c'est un serveur
externe !).
Pour ceci, il vous suffit de cliquer sur
le bouton "Compiler le serveur"a
de... Compistart.Un peu évident avec
un nom pareil!
Ce readme sera bientôt remplacé par une version plus propre.
Je vous joins aussi l'idée initiale du logiciel :



Les logiciels idéals pour moi…. Si seulement ils existaient😥
Logiciel

Apollo12

1
août 2020
Bonjour tout le monde :slightly_smiling_face:,

J’ouvre ce post pour vous faire part de ce à quoi ressemblerait le logiciel idéal pour créer un serveur Minitel et le gérer.

1°) Il s’agirait d’une suite de plusieurs logiciels tournant sous Windows 3.11, avec chacun leur fonction :

VDT Edit serait l’éditeur de page videotex. Entièrement graphique, son fonctionnement devrait être le plus proche possible d’un logiciel de PAO, afin d’être simple et agréable à utiliser :blush:. Cela pourrait ressembler un petit peu à MiEdit, qui permet de placer simplement les différents éléments sur la page. Évidemment, on pourrait avoir une prévisualisation sur un vrai Minitel connecté sur un port série de l’ordinateur

VDT Pics serait un logiciel permettant de convertir une image BMP, PCX , voir même JPEG en page videotex ou DRCS. Son fonctionnement serait similaire à celui d’un logiciel d’édition d’images. À savoir qu’une fois l’image ouverte, on aurait différentes réglettes permettant de modifier le contraste, la luminosité etc… pour avoir le meilleur résultat possible. Ainsi que la possibilité de définir la zone à convertir en quelques clics, de même que la taille de l’image sur la page videotex. Bien évidemment il offrirait la possibilité d’avoir un aperçu du résultat final aux différentes étapes, avant la compilation en page videotex. Il pourrait aussi être exécuté à l’intérieur de VDT Edit, pour insérer directement une image dans une page videotex.

Arbo edit serait l’éditeur d’arborescences, et permettrait de créer le serveur entant que tel. Pour se faire, il permettrait de créer un organigramme où chaque case représenterait une page VDT avec son nom (Accueil, sommaire, etc…) . À la création de chaque nouvelle case, on aura qu’à insérer dedans une page VDT Créée avec VDT edit, via la commande « sélectionner le fichier de page » . Ensuite, pour gérer les connexions avec les autres pages, et les saisies, il suffirait de cliquer sur :« Gérer les interactions » . Là, on aurait une boîte de dialogue permettant de définir différentes interactions. Premièrement, il faudrait faire « Nouvelle interaction », et le programme proposerait plusieurs choix : Interactions par touche, interactions par codes.

Le mode « interactions par touche » permettrait de définir l’action à effectuer avec l’appuie sur une touche de fonction du terminal (Suite, Envoi, Annulation, etc…). Par exemple, le moment où il faut appuyer sur « Suite » pour avoir accès à la page d’accueil du serveur.

Le mode « interactions par codes » serait utilisé pour définir l’action à effectuer après l’entrée d’un code, ou d’un chiffre, et l’appuie sur la touche « Envoi » .

Unr fois le type d’interaction sélectioné, le logiciel proposerait de choisir la touche appuyée/le code entrée, et l’action à effectuer (Aller à telle page, afficher le message suivant dans la zone supérieure de l’écran. Etc…).

Les différentes interactions de chaque pages seraient regroupés dans tableaux. Un pour les interactions par touches, l’autre pour les interactions par code.

Les tableaux comporteraient les colonnes suivantes : N° d’interaction, Touches ou Code, action à réaliser.

Ce logiciel offrirait aussi des assistants « Création de messagerie » et « Création de de forum ».

L’assistant « Creation de messagerie » permettrait de sélectionner le type de messagerie que l’on souhaite créer :

Messagerie ouverte : Toute personne se connectant au serveur peut créer un compte, et utiliser la messagerie sans restrictions.

Messagerie ouverte fermée (Les personnes se connectant au serveur peuvent écrire des messages aux comptes de messagerie en laissant leurs coordonnées (adresse, téléphone etc…), mais ne peuvent pas créer de comptes, ni réellement utiliser la messagerie. Les comptes sont inscrits en « dur », et seul l’administrateur du serveur peut en creer de nouveaux, ou en supprimer. Ce type de messagerie peut être utilisé sur les serveurs d’entreprise, afin que les clients puissent demander l’envoi d’une brochure par exemple.

Messagerie fermée : Seul les comptes peuvent s’écrire des messages, les personnes connectés « normales » n’ont pas accès à cette messagerie, et ne peuvent pas l’utiliser. Les comptes sont inscrits en « dur », et seul l’administrateur peut en créer ou en supprimer.

Une fois le type de messagerie créée, il permettrait de créer des comptes, de définir la longueur des messages, la nécessité de changer son mot de passe après la première connexion etc…

Une fois la messagerie créée, il suffirait de l’intégrer au reste de l’arborescence, avec éventuellement possibilité de la « disloquer », pour rendre le serveur plus lisible.

Pour l’assistant « Création de forum », il permettrait de définir les différentes rubriques, et de créer un pseudo « admin » qui pourrait éventuellement supprimer des messages, et donner le grade de modérateur.

La page de connexion messagerie et forum pourrait être commune bien-sur.

Il serait également possible de créer des « Zones flexibles » sur les pages, pouvant être mis à jour sans nécessiter de recompiler le serveur. Cela pourrait être utilisé pour indiquer des informations destinés à évoluer (programme de cinéma, listes d’expositions etc…)

Une fois l’arborescence créée, on pourrait l’enregistrer dans un fichier spécial avec l’extension « .ARB »

Compistart serait un logiciel qui comme son nom l’indique aurait pour mission de compiler le serveur, et le faire démarrer. Pour se faire, il suffirait de sélectionner le fichier .ARB correspondant au serveur que l’on souhaite compiler. Ensuite, le logiciel demanderait différentes informations, comme le nombre de voies, le type de modem utilisé (Minitel 1B, Minitel 2, Autre modem etc…), lancement du serveur au démarrage de Windows, horaires de disponibilité etc…

Une fois les informations renseignés, le logiciel « compilerait » le serveur, et créerait différents dossiers contenant les divers fichiers nécessaire à son fonctionnement, puis l’exécutable MS DOS correspondant à son programme, ainsi qu’un fichier « .PIF » permettant de lancer ce dernier en mode « réduit », afin que le PC puisse être utilisé pour d’autres travaux sous Windows en même temps. Si le serveur a vocation à démarrer en même temps que Windows, un raccourci vers le fichiers « .PIF » sera automatiquement ajouté au groupe de programme « démarrage », et Compistart demanderait de redémarrer Windows.

Compistart possèderait également des outils pour gérer la messagerie et/ou le forum du serveur (Création de pseudos, suppression, etc)
