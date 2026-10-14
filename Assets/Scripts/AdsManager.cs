using UnityEngine;
using UnityEngine.Advertisements;


public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener

{
    public static AdsManager instance;
    string gameID = "6197483";

    string interstitialAdID = "Interstitial_Android";
    string bannerAdID = "Banner_Android";


    private void Awake()
    {
        instance = this;

        InitializeAds();
    }

    void InitializeAds()
    {
        Advertisement.Initialize(gameID, false, this);
    }

    public void ShowAds()
    {
        Advertisement.Load(interstitialAdID, this);

        Advertisement.Show(interstitialAdID, this);
    }

    //GameOver
    //Ads.Manager.instance.ShowAds();

    public void ShowBannerAds()
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);

        Advertisement.Banner.Load(bannerAdID);

        Advertisement.Banner.Show(bannerAdID);
    }

    // Start
    //Ads.manager.instance.ShowBannerAds();

    public void OnInitializationComplete()
    {
        Debug.Log("Initialized");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Ads Loaded");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("Ads Clicked");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("Ads Complete");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("Ads Failed");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Ads Started");
    }
}
