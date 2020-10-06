# Création du projet
* Lancer Unity Hub
* Créer un nouveau projet 3D
* Une fois le projet créé, il devrait s'ouvrir
* Directement aller dans "Edit" > "Preferences..."
* Dans l'onglet "External Tool", choisir "Visual studio 2019 (community)" pour "External script editor", celà permet a Visual Studio d'intégrer des fonctions/complétions de Unity
* ![GitHub Logo](/img/External_tools.png)
* Télécharger puis importer le [package pour kinect](https://assetstore.unity.com/packages/3d/characters/kinect-v2-examples-with-ms-sdk-18708 "Package Kinect")
    
    **La création du projet est terminée**

# Projet HelloWorld
## Ajouter un squelette

Il faut récupérer le squelette présent dans la démo du package précédement installé en ouvrant la scene "KinectAvatarsDemo4" présente dans Assets > K2Exemples > KinectDemos > AvatarsDemo

![GitHub Logo](/img/KinectAvatarsDemo4.png)

Copier l'objet "KinectController" et le coller dans votre scène (pour revenir à votre scene de départ > File > Open Scene > Scenes > SampleScene.unity)
Pour ajouter un personnage a votre squelette, cliquez sur l'objet "KinectController", dans le script "User Avatar Matcher" séléctionnez le personnage voulu dans "Avatar Model" (ici je choisis "Robot")

![GitHub Logo](/img/choisirSkin.png)

Double-cliquez sur l'élément Robot dans "Avatar Model" pour trouver sa source et glissez le dans votre hiérarchie

![GitHub Logo](/img/elementhierarchie.png)

Ce nouvel object Robot vous permettra de gérer les futures collisions.
Vous pouvez le rendre invisible en décochant la case à côté de son nom pour évitez qui vous dérange lors des phase de jeu

![GitHub Logo](/img/uncheck.png)

Si vous lancer votre projet, un personnage reproduisant vos mouvements devrait maintenant apparaître.

## Créer les objets

Pour cet exemple vous allez créez deux cubes de couleur bleu, dès que une des mains du joueur entre en contact avec un des cube, il devient rouge, et s'il enlève sa main, il redevient bleu.

Créez un cubes (Clique droit dans la hérarchie > new 3D object > 3D Cube)

Sélectionnez votre cube et dans l'inspecteur, cliquez sur "Add Component" > Box Collider et cochez "is Trigger" pour le définir comme "déclanché"

![GitHub Logo](/img/boxcollider.png)

Dans le dossier "Assets", créez un nouveau dossier "Material", il contiendra les deux couleurs que le cube peu avoir.
Clique droit dans le dossier "Material" > Create > Material, donnez lui une couleur bleu.
Dupliquez le matérial bleu puis donnez lui la couleur rouge (n'oubliez pas de bien renommer vos nouveau material !).

Glissez votre nouveau material bleu sur votre cube précédemment créé, puis dupliquez votre cube.

Vous avez miantenant deux cubes bleus, un sera à gauche, un à droite.

![GitHub Logo](/img/checkpoint1.png)

vous allez ensuite donner un box collider au deux poignet du Robot

pour ce faire, sélectionner le poignet (wrist) du Robot et Add component > Box Collider.

![GitHub Logo](/img/robotwrist.png)

Ajoutez également un RigidBody (décochez use gravity et cochez is Kinematic).

![GitHub Logo](/img/rigid.png)

**Création des objets terminée**

## Gérer les collisions

Avant de gérer les collisions il faut comprendre les collisions !
les poignets sont des "déclancheurs" (c'est eux qui vont toucher des choses) et les cubes sont des "déclanchés" (il font quelque chose s'ils sont touché ou non).








