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
![GitHub Logo](/img/elementhierarchie.png.png)
Ce nouvel object Robot vous permettra de gérer les futures collisions.
Vous pouvez le rendre invisible en décochant la case à côté de son nom pour évitez qui vous dérange lors des phase de jeu
![GitHub Logo](/img/uncheck.png.png)

Si vous lancer votre projet, un personnage reproduisant vos mouvements devrait maintenant apparaître.

## Gérer les collisions

Avant de gérer les collision ils faut comprendre les collisions et c'est assez simple :
d'un côté il y a l'object déclancheur et l'object déclanché, si le déclancheur touche l'objet déclanché alors il se passe quelque chose.


