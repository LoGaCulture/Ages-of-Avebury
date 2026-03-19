# Ages of Avebury

A locative augmented reality game set in the historic Avebury stone circle, blending heritage preservation with interactive storytelling.

[![Google Play](https://img.shields.io/badge/Google%20Play-Download-green?logo=google-play)](https://play.google.com/store/apps/details?id=uk.ac.soton.logaculture.agesofavebury)
[![App Store](https://img.shields.io/badge/App%20Store-Download-blue?logo=apple)](https://apps.apple.com/gb/app/ages-of-avebury/id6746870229)

## About

**Ages of Avebury** is an interactive location-based AR game developed as part of the [LoGaCulture](https://logaculture.eu/) European research project. Players physically explore Avebury while experiencing the site across three pivotal time periods in history.

### The Story

You play as a surveyor hired by the National Trust to document the Avebury stone circle. During your survey, you are mysteriously transported through time:

1. **The Neolithic Era** - Witness the original construction of the stone circle and help place the ancient monoliths
2. **The Medieval Period** - Face difficult choices as villagers seek to destroy the stones for building materials
3. **The Present Day** - Return to modern Avebury and see the consequences of your decisions

### Gameplay Features

- **Create Your Own Stones** - Using your device's camera, capture your silhouette to create two personalized standing stones that become part of the landscape
- **Discover Other Visitors** - Find a stone left behind by another time traveler from the Neolithic era
- **Moral Choices** - In the medieval period, decide whether to preserve or destroy each stone - the villagers have compelling reasons for their building projects
- **AR Finale** - After returning to the present, walk into the field and see your stones or buildings appear in augmented reality, placed where they would stand in the real landscape
- **AR Map Experience** - Return to the barn for an optional AR miniature map of Avebury, where you can watch the stone circle being constructed and see your stones and buildings placed within it

## Technology

Ages of Avebury is built using [LUTE (LoGaCulture Unity Toolkit/Engine)](https://github.com/LoGaCulture/LUTE), a Unity framework designed for creating narrative location-based games focused on heritage preservation.

### Core Technologies

| Technology | Purpose |
|------------|---------|
| **Unity 6** | Game engine (URP rendering pipeline) |
| **LUTE** | Narrative and location-based game framework |
| **AR Foundation** | Cross-platform AR (ARCore for Android, ARKit for iOS) |
| **Mapbox** | Maps and geolocation services |
| **MediaPipe** | Real-time human silhouette detection |
| **TensorFlow Lite** | On-device machine learning inference |
| **Marching Cubes** | 3D mesh generation from 2D silhouettes |

### How the Stone Creation Works

1. **Selfie Segmentation** - MediaPipe's selfie segmentation model isolates the human figure from the camera feed
2. **Contour Extraction** - The silhouette outline is traced using marching squares algorithm
3. **3D Extrusion** - The 2D contour is converted into a 3D standing stone using metaball-based marching cubes
4. **Procedural Detailing** - Perlin noise adds natural rock-like texture and irregularities

## Requirements

- **Android**: Android 8.0+ with ARCore support
- **iOS**: iOS 13.0+ with ARKit support
- **Location**: Best experienced on-site at Avebury, Wiltshire, UK

## Project Structure

```
Assets/
├── Art/                    # Visual assets, animations, textures
├── Audio/                  # Sound effects and music
├── Code/Scripts/           # Game-specific scripts
│   ├── mediapipe/          # Selfie segmentation implementation
│   ├── MarchingCubes/      # 3D mesh generation
│   └── LUTE Scripts/       # Custom LUTE orders
├── Level/Scenes/           # Unity scenes
└── LUTE/                   # LUTE framework (submodule)
    └── Assets/
        ├── LUTE/           # Core LUTE engine
        └── Mapbox/         # Mapbox SDK
```

## Credits

### Development

This project is part of [LoGaCulture](https://logaculture.eu/), a European research project focused on using games and interactive experiences for cultural heritage preservation.

### Third-Party Libraries

- [LUTE](https://github.com/LoGaCulture/LUTE) - LoGaCulture Unity Toolkit/Engine
- [MediaPipe Unity Plugin](https://github.com/homuler/MediaPipeUnityPlugin) - Human pose and segmentation
- [Mapbox Unity SDK](https://www.mapbox.com/unity/) - Maps and location services
- [Marching Cubes](https://github.com/Scrawk/Marching-Cubes) - Isosurface mesh generation
- [UniTask](https://github.com/Cysharp/UniTask) - Efficient async/await for Unity

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Links

- [LoGaCulture Project](https://logaculture.eu/)
- [LUTE Framework](https://github.com/LoGaCulture/LUTE)
- [Google Play Store](https://play.google.com/store/apps/details?id=uk.ac.soton.logaculture.agesofavebury)
- [Apple App Store](https://apps.apple.com/gb/app/ages-of-avebury/id6746870229)


