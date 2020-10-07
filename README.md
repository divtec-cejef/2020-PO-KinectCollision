# Création d'un projet qui utilise la Kinect
Projet qui a pour but de montrer comment installer un environnement kinect de A à Z et ensuite créer un petit projet gérant la collision d'un squelette.

## Sommaire
- [Création d'un projet qui utilise la Kinect](#création-dun-projet-qui-utilise-la-kinect)
  - [Sommaire](#sommaire)
  - [Environnement de développement](#environnement-de-développement)
  - [Introduction](#introduction)
  - [Matériel et Logiciel](#matériel-et-logiciel)
    - [Matériel nécessaire](#matériel-nécessaire)
    - [Kinect](#kinect)
  - [Environnement Unity](#environnement-unity)
    - [Programmation externe pour le personnage](#programmation-externe-pour-le-personnage)
      - [User Avatar Matcher](#user-avatar-matcher)
      - [Avatar Controller](#avatar-controller)
  - [Sources](#sources)
    - [Unity](#unity)
    - [Package(s) Unity](#packages-unity)
- [Création du projet GelloWorld](#création-du-projet-gelloworld)
- [Projet HelloWorld](#projet-helloworld)
  - [Ajouter un squelette](#ajouter-un-squelette)
  - [Créer les objets](#créer-les-objets)
  - [Gérer les collisions](#gérer-les-collisions)

## Environnement de développement

Installer les outils suivant :
* Kinect-v2-with-MS-SDK-v2.19.2
* [Unity 2019.4.8f](https://unity3d.com/fr/get-unity/download/archive)
* Visual Studio Community 2019 (à installer en même temps)
* Les packages suivant
  * [Free MatCap Shaders 1.4.0.0](https://assetstore.unity.com/packages/vfx/shaders/free-matcap-shaders-8221)

## Introduction

[Le projet Movin&#39;Shape](https://github.com/divtec-cejef/2020-PO-Movin-Shapes) est en version Unity 2019.4.8f1 et utilise une caméra Kinect V2. Cette documentation montre comment créer le projet sur les mêmes bases.

Il est nécessaire de maîtriser les bases de Unity et du C# pour comprendre les différentes explications.

## Matériel et Logiciel

### Matériel nécessaire

Voici la liste du matériel nécessaire au fonctionnement du jeu :

- Un ordinateur avec Windows 10 à jour
- Une caméra Kinect V2

Voici la liste des logiciels et packages Unity nécessaire au fonctionnement du jeu :

- [Unity Hub](https://unity3d.com/fr/get-unity/download) / Unity version 2019.4.8f1
- Kinect-v2-with-MS-SDK-v2.19.2
- [Volumetric Lines 3.0.2](https://assetstore.unity.com/packages/tools/particles-effects/volumetric-lines-29160)
- [ProBuilder](https://unity3d.com/fr/unity/features/worldbuilding/probuilder) v4.2.3
- [Free MatCap Shaders 1.4.0.0](https://assetstore.unity.com/packages/vfx/shaders/free-matcap-shaders-8221)

### Kinect

Lorsque la Kinect est branchée au PC pour la première fois, la Kinect installe automatiquement tous les pilotes nécessaires à son fonctionnement. Pour tester son fonctionnement, il faut installer le [SDK de Microsoft](https://www.microsoft.com/en-us/download/details.aspx?id=44561) et lancer le testeur. Attention, l&#39;installation des pilotes peut prendre beaucoup de temps.

## Environnement Unity

Il suffit de télécharger [Unity Hub](https://unity3d.com/fr/get-unity/download) et installer ensuite Unity version 2019.4.8f1. Si la version n&#39;apparaît pas, on peut la trouver dans [les archives des versions Unity](https://unity3d.com/fr/get-unity/download/archive). Il faut aussi installer Visual Studio 2019 qui vient normalement directement s&#39;installer avec avec Unity v2019.4.8f1.

Le package Unity de reconnaissance de squelettes Kinect ne fonctionne pas sur les versions plus récentes.

Il faut également se connecter avec un compte Unity ID pour pouvoir télécharger des packages. Attention, il faut se connecter à un autre réseau que DIVTEC.LOCAL pour le faire.

### Programmation externe pour le personnage

La gestion des personnages se fait depuis un code obtenu auprès de M. Filkov qui nous a gentiment partagé un package permettant la gestion des personnages avec une Kinect V2.
 Site internet : [https://rfilkov.com](https://rfilkov.com/)

Nom du package Unity : Kinect-v2-with-MS-SDK-v2.19.2

Deux parties du code ont été modifiées, une partie dans User Avatar Matcher et la seconde dans Avatar Controller.

#### User Avatar Matcher

Cette partie concerne l&#39;ajout d&#39;un deuxième avatar, suivant le nombre de personne détecté, l&#39;avatar est différent :

#### Avatar Controller

Cette partie concerne l&#39;inversement de la position de l&#39;axe Z du personnage. En la passant à « true » on indique à la Kinect que le personnage doit faire l&#39;inverse de la personne. C&#39;est-à-dire lorsque que le joueur s&#39;approche de la caméra Kinect, le personnage s&#39;éloigne de la caméra du jeu et inversement :

## Sources

### Unity

- Unity Hub : [https://unity3d.com/fr/get-unity/download](https://unity3d.com/fr/get-unity/download)
- Archives Unity : [https://unity3d.com/fr/get-unity/download/archive](https://unity3d.com/fr/get-unity/download/archive)
- Documentation Unity : [https://docs.unity3d.com/Manual/index.html](https://docs.unity3d.com/Manual/index.html)

### Package(s) Unity

- Volumetric Lines 3.0.2 : [https://assetstore.unity.com/packages/tools/particles-effects/volumetric-lines-29160](https://assetstore.unity.com/packages/tools/particles-effects/volumetric-lines-29160)
- Probuilder : [https://unity3d.com/fr/unity/features/worldbuilding/probuilder](https://unity3d.com/fr/unity/features/worldbuilding/probuilder)
- Free Matcap Shaders 1.4.0.0 : [https://assetstore.unity.com/packages/vfx/shaders/free-matcap-shaders-8221](https://assetstore.unity.com/packages/vfx/shaders/free-matcap-shaders-8221)
- Mr. Rumen Filkov: [https://rfilkov.com/](https://rfilkov.com/)

# Création du projet GelloWorld
* Lancer Unity Hub
* Créer un nouveau projet 3D
* Une fois le projet créé, il devrait s'ouvrir
* Directement aller dans "Edit" > "Preferences..."
* Dans l'onglet "External Tool", choisir "Visual studio 2019 (community)" pour "External script editor", celà permet a Visual Studio d'intégrer des fonctions/complétions de Unity

    ![GitHub Logo](/img/External_tools.png)
* Télécharger puis importer le [package pour kinect](https://assetstore.unity.com/packages/3d/characters/kinect-v2-examples-with-ms-sdk-18708 "Package Kinect")
    
    **La création du projet est terminée**

# Projet HelloWorld
## Ajouter un squelette

Il faut récupérer le squelette présent dans la démo du package précédement installé en ouvrant la scene "KinectAvatarsDemo4" présente dans Assets > K2Exemples > KinectDemos > AvatarsDemo

![Pscreen de kinectAvatarDemo4](/img/KinectAvatarsDemo4.png)

Copier l'objet "KinectController" et le coller dans votre scène (pour revenir à votre scene de départ > File > Open Scene > Scenes > SampleScene.unity)
Pour ajouter un personnage a votre squelette, cliquez sur l'objet "KinectController", dans le script "User Avatar Matcher" séléctionnez le personnage voulu dans "Avatar Model" (ici je choisis "Robot")

![Pscreen choix du skin](/img/choisirSkin.png)

Double-cliquez sur l'élément Robot dans "Avatar Model" pour trouver sa source et glissez le dans votre hiérarchie

![Pscreen hiérarchie](/img/elementhierarchie.png)

Ce nouvel object Robot vous permettra de gérer les futures collisions.
Vous pouvez le rendre invisible en décochant la case à côté de son nom pour évitez qui vous dérange lors des phase de jeu

![Pscreen décocher object](/img/uncheck.png)

Si vous lancer votre projet, un personnage reproduisant vos mouvements devrait maintenant apparaître.

**➡️ Ajout du squelette terminé**

## Créer les objets

Pour cet exemple vous allez créez deux cubes de couleur bleu, dès que une des mains du joueur entre en contact avec un des cube, il devient rouge, et s'il enlève sa main, il redevient bleu.

Créez un cubes (Clique droit dans la hérarchie > new 3D object > 3D Cube)

Sélectionnez votre cube et dans l'inspecteur, cliquez sur "Add Component" > Box Collider et cochez "is Trigger" pour le définir comme "déclanché"

![Pscreen boxCollider component](/img/boxcollider.png)

Dans le dossier "Assets", créez un nouveau dossier "Material", il contiendra les deux couleurs que le cube peu avoir.

Clique droit dans le dossier "Material" > Create > Material, donnez lui une couleur bleu.

Dupliquez le matérial bleu puis donnez lui la couleur rouge (n'oubliez pas de bien renommer vos nouveau material !).

Glissez votre nouveau material bleu sur votre cube précédemment créé, puis dupliquez votre cube.

Vous avez maintenant deux cubes bleus, un sera à gauche, un à droite.

![Pscreen deux cubes bleus](/img/checkpoint1.png)

vous allez ensuite donner un box collider au deux poignet du Robot

pour ce faire, sélectionner le poignet (wrist) du Robot et Add component > Box Collider.

![Pscreen wrist du robot](/img/robotwrist.png)

Ajoutez également un RigidBody (décochez use gravity et cochez is Kinematic).

![Pscreen rigidBody component](/img/rigid.png)

**➡️ Création des objets terminée**

## Gérer les collisions

Avant de gérer les collisions il faut comprendre les collisions !

Les cubes sont des "déclancheurs" (ils font quelque chose s'ils sont touché ou non).

Tout ça se gère via un script.

Dans votre dossier "Assets", clique-droit > create > C# script et nommez-le "collision".

Ouvrez-le (il devrait s'ouvrir avec visual studio !).

Supprimez les fonction Start et Update.

Créez deux variables qui représenteront les deux coloris des cubes :

```C#
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

//Gère les collisions entre le personnage et les objets présents
public class Collisions : MonoBehaviour   
{
    public Material rouge;
    public Material bleu;
}
```

Créez deux fonctions, une "OnTriggerEnter" et une "OnTriggerExit" avec comme paramètre ```(Collider cube)```.

La fonction ```OnTriggerEnter``` détecte quand une collision se produit, la fonction ```OnTriggerExit``` détecte quand la collision s'arrête.


```C#
private void OnTriggerEnter(Collider cube)
    {
        
    }

    private void OnTriggerExit(Collider cube)
    {

    }
```

Le paramètre cube référence le box collider du cube qui sera touché.

Dans la fonction ```OnTriggerEnter```, nous allons changer la couleur du cube en rouge.

On récupère pour ça le l'objet du collider détecté par la collision (donc le cube) pour pouvoir modifié son paramètre Material

On attribue notre Material rouge au material du cube.

```C#
private void OnTriggerEnter(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = rouge;
    }
```

Et lorsque la collision s'arrête, on remplace le Material du cube par notre Material bleu.

Donc dans la fonction ```OnTriggerExit``` :

```C#
private void OnTriggerExit(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = bleu;
    }
```

Maintenant il faut faire le lien entre vos deux variables Material et vos deux Material.

Pour se faire : sauvegarder votre script (CTRL+S) puis fermer visual studio.

Sélectionnez votre script, deux paramètres sont maintenant disponnibles pour votre script : bleu et rouge.

![Pscreen nouveau param script](/img/scriptparam.png)

Glissez ce script sur le Left_Wrist du robot, lorsque vous sélectionnez Left_Wrist du robot, le script devrait apparaître dans l'inspector.

Glissez maintenant vos Material bleu et rouge dans les paramètre bleu et rouge du script collision présent sur Left_Wrist du robot.

![Pscreen param du script rempli](/img/paramscript.png)

Faite exactement la même chose pour le Right_Wrist du robot.

**➡️ Gestion des collisions terminée**

Il vous suffit maintenant de lancer le projet pour essayer de toucher les cubes.

Il faudra sûrement déplacer les cubes pouvoir être capable de les atteindre.

**➡️ Projet HelloWorld terminé**