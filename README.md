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
- [Création du projet HelloWorld](#création-du-projet-helloworld)
- [Projet HelloWorld](#projet-helloworld)
  - [Créer le gestionnaire kinect](#créer-le-gestionnaire-kinect)
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

# Création du projet HelloWorld
* Lancer Unity Hub
* Créer un nouveau projet 3D
* Une fois le projet créé, il devrait s'ouvrir
* Directement aller dans "Edit" > "Preferences..."
* Dans l'onglet "External Tool", choisir "Visual studio 2019 (community)" pour "External script editor", cela permet a Visual Studio d'intégrer des fonctions/complétions de Unity

    ![GitHub Logo](/img/External_tools.png)
* Télécharger puis importer le [package pour kinect](https://assetstore.unity.com/packages/3d/characters/kinect-v2-examples-with-ms-sdk-18708 "Package Kinect")
    
    **La création du projet est terminée**

# Projet HelloWorld
## Créer le gestionnaire kinect

Il faut d'abord importer le package kinect.

Assurez-vous que votre projet est bien ouvert, puis exécutez *Kinect.2.0.1410.19000.unitypackage* présent dans le dossier *KinectForWindows_UnityPro_2.0.1410*

Unity va vous proposer d'importer, acceptez.

Si une erreur survient vous proposant de continuer avec ou sans backup, appuyer simplement sur "I have made a backup".

Dans le dossier *KinectForWindows_UnityPro_2.0.1410* vous trouverez des dossiers *GreenScreen* et *KinectView*, glissez-les dans le dossier assets de votre projet

![GitHub Logo](/img/exemplehierarchie.png)

Dans votre hiérarchie, créez un nouvel objet vide, nommez-le "BodySourceManager" (clique-droit dans la hiérarchie > create > Empty)

Sélectionnez cet objet, dans l'inspector > add component > recherchez le script "Body Source Manager" > ajoutez-le.

Si vous lancez le projet, la kinect devrait maintenant s'allumer (un rectangle blanc a côté de l'objectif + des rectangles rouge au milieu).

**➡️ Création du gestionnaire kinect terminée**

## Créer les objets

Pour cet exemple vous allez créer deux cubes de couleur bleu, dès qu'une des mains du joueur entre en contact avec un des cube, il devient rouge, et s'il enlève sa main, il redevient bleu.

Créez un cube (Clique droit dans la hérarchie > new 3D object > 3D Cube)

Sélectionnez votre cube et dans l'inspecteur, cliquez sur "Add Component" > Box Collider et cochez "is Trigger" pour le définir comme "déclenché"

![Pscreen boxCollider component](/img/boxcollider.png)

Dans le dossier "Assets", créez un nouveau dossier "Material", il contiendra les deux couleurs que le cube peut avoir.

Clique droit dans le dossier "Material" > Create > Material, donnez lui une couleur bleu.

Dupliquez le matérial bleu puis donnez lui la couleur rouge (n'oubliez pas de bien renommer vos nouveaux materials !).

Glissez votre nouveau material bleu sur votre cube précédemment créé, puis dupliquez votre cube.

Vous avez maintenant deux cubes bleus, un sera à gauche, un second à droite.

![Pscreen deux cubes bleus](/img/checkpoint1.png)

Maintenant vous allez créer une sphère qui représentera une main.

Dans votre hiérarchie > clique-droit > create > 3D sphere.

Nommez-la "main_gauche".

Dans l'inspector de la sphère > Add component > Sphere collider.

Le radius devrait se régler automatiquement.

A nouveau dans l'inspector de la sphère > Add component > RigidBody.

Décochez **Use Gravity** et cochez **Is Kinematic**

Puis une dernière fois dans l'inspector de la sphère > Add component > script "Detect Joints".

Ce script permet de faire le lien entre l'objet et ce qu'il est sensé représenter

Ici notre sphère représentera la main gauche.

Dans les paramètres du script Detect Joints, glissez votre objet bodySourceManager dans le paramètre Body Src Manager.

Puis sélectionnez "Hand Left" dans le paramètre **Tracked Joints**

Voilà à quoi devrait ressembler l'inspector de votre sphère :

![Pscreen inspector](/img/mainscreen.png)

Dupliquez votre sphère pour en faire une main droite.

N'oubliez pas de changer le paramètre de **Tracked Joints** de cette nouvelle sphère en "Hand Right" et de renommer l'objet en "main_droite".


**➡️ Création des objets terminée**

## Gérer les collisions

Avant de gérer les collisions il faut comprendre les collisions !

Les cubes sont des "déclencheurs" (ils font quelque chose s'ils sont touchés ou non).

Tout ce processus est géré par un script.

Dans votre dossier "Assets", clique-droit > create > C# script et nommez-le "collision".

Ouvrez-le (il devrait s'ouvrir avec Visual Studio !).

Supprimez les fonctions Start et Update.

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

On récupère pour ça l'objet du collider détecté par la collision (donc le cube) pour pouvoir modifier son paramètre Material

On attribue notre Material rouge au material du cube.

```C#
private void OnTriggerEnter(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = rouge;
    }
```

Et lorsque la collision s'arrête, on remplace le material du cube par notre Material bleu.

Donc dans la fonction ```OnTriggerExit``` :

```C#
private void OnTriggerExit(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = bleu;
    }
```

Maintenant il faut faire le lien entre vos deux variables Material et vos deux Material.

Pour se faire : sauvegardez votre script (CTRL+S) puis fermer Visual Studio.

Sélectionnez votre script, deux paramètres sont maintenant disponibles pour votre script : bleu et rouge.

![Pscreen nouveau param script](/img/scriptparam.png)

Glissez ce script sur la sphère main_gauche, lorsque vous sélectionnez le script Collision sur la sphère, le script devrait apparaître dans l'inspector.

Ajoutez vos Material bleu et rouge dans les paramètres du script.

![Pscreen param du script rempli](/img/maingauche.png)

Faite exactement la même chose pour la sphère main_droite du robot.

**➡️ Gestion des collisions terminée**

Il vous suffit maintenant de lancer le projet pour essayer de toucher les cubes.

Il faudra sûrement déplacer les cubes pour être capable de les atteindre (ici, ils ont été étirés).

![Pscreen param du script rempli](/img/helloworld.gif)

**➡️ Projet HelloWorld terminé**
