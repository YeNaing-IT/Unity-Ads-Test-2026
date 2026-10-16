# Unity Ads Test 2026

A minimal Unity 6 project for testing **Unity Ads** (`com.unity.ads`) on Android. One scene, one script, two buttons: one shows an interstitial ad, the other shows a banner ad. It is meant as a reference and sandbox for wiring ads into a game, not as a game itself.

## Features

- Initializes the Unity Ads SDK on startup
- **Interstitial ad**, shown on button press (`Interstitial_Android` placement)
- **Banner ad**, shown at the bottom centre of the screen (`Banner_Android` placement)
- Logs every SDK callback (initialized, loaded, started, clicked, completed, failed) to the Console
- A singleton `AdsManager.instance` so any other script can trigger an ad

## Usage

The scene's buttons already call the two public methods to show ads:
<img width="415" height="830" alt="image" src="https://github.com/user-attachments/assets/51606465-e7ed-4421-84cd-94883222566f" />

### Show Ads Screen
<img width="406" height="822" alt="image" src="https://github.com/user-attachments/assets/0d42efe2-0053-413c-83fe-c39a068a6ea6" />

### Show Banner Ads
<img width="406" height="822" alt="image" src="https://github.com/user-attachments/assets/426149c5-882a-44ec-a2b5-8622b8a5199d" />


| Method | What it does |
|---|---|
| `ShowAds()` | Loads and shows the interstitial ad |
| `ShowBannerAds()` | Sets the banner to bottom-centre, then loads and shows it |

## Notes

This is a practice project, so a few things are kept simple:

- `ShowAds()` calls `Load` and `Show` back to back, so the first press may fail if the ad hasn't loaded yet.
- `OnInitializationFailed` and `OnUnityAdsFailedToLoad` are not implemented yet.
- Android only; iOS would need its own Game ID and `*_iOS` placements.
