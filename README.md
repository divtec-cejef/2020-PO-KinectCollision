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
  - [Autres](#autres)

## Environnement de développement

Installer les outils suivant :
* Kinect-v2-with-MS-SDK-v2.19.2
* [Unity 2019.4.8f](https://unity3d.com/fr/get-unity/download/archive)
* Visual Studio Community 2019 (à installer en même temps)
* Les packages suivant
  * [Volumetric Lines 3.0.2](https://assetstore.unity.com/packages/tools/particles-effects/volumetric-lines-29160)
  * [ProBuilder v4.2.3](https://unity3d.com/fr/unity/features/worldbuilding/probuilder)
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

## Autres

- Fond étoilé : [https://unsplash.com/photos/qVotvbsuM\_c](https://unsplash.com/photos/qVotvbsuM_c)