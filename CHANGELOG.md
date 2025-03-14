⚠️ In version 4.0.0, we changed the iOS bridge from AppboyKit, which is written in Objective-C, to the new [Swift SDK](https://github.com/braze-inc/braze-swift-sdk). If you are upgrading from a version below 4.0.0 to a version above 4.0.0, please read [the instructions](https://github.com/braze-inc/braze-xamarin-sdk/blob/master/CHANGELOG.md#400) to ensure a smooth transition and backward compatibility.

## 4.0.3

##### Added
- Updated the Android binding from [Braze Android 30.1.0 to 30.4.0](https://github.com/braze-inc/braze-android-sdk/compare/v30.1.0...v30.4.0#diff-06572a96a58dc510037d5efa622f9bec8519bc1beab13c9f251e97e657a9d4ed).
- Updated the iOS binding from [Braze Swift SDK 8.0.1 to 8.4.0](https://github.com/braze-inc/braze-swift-sdk/compare/8.0.1...8.4.0#diff-06572a96a58dc510037d5efa622f9bec8519bc1beab13c9f251e97e657a9d4ed).

## 4.0.2

##### Added
- Updated the Android binding from [Braze Android SDK 29.0.1 to 30.1.0](https://github.com/braze-inc/braze-android-sdk/compare/v29.0.1...v30.1.0#diff-06572a96a58dc510037d5efa622f9bec8519bc1beab13c9f251e97e657a9d4ed).
- Updated the iOS binding from [Braze Swift SDK 7.6.0 to 8.0.1](https://github.com/braze-inc/braze-swift-sdk/compare/7.6.0...8.0.1#diff-06572a96a58dc510037d5efa622f9bec8519bc1beab13c9f251e97e657a9d4ed).

## 4.0.1

##### Fixed
- Corrected the incorrect dependency versions in the nuspecs of recent iOS libraries.

## 4.0.0

##### Breaking
- This version updates the iOS binding to use the [Braze Swift SDK](https://github.com/braze-inc/braze-swift-sdk/). Most iOS public APIs have changed, please refer to our [migration guide](https://braze-inc.github.io/braze-swift-sdk/documentation/braze/appboy-migration-guide) (Swift) for guidance about replacement to use. We provide compatibility bindings to keep making use of the old public APIs.
  - The iOS binding is now composed of multiple modules:
    - **BrazeKit**: Main SDK library providing support for analytics and push notifications (nuget: [Braze.iOS.BrazeKit](https://www.nuget.org/packages/Braze.iOS.BrazeKit)).
    - **BrazeUI**: Braze-provided user interface library for In-App Messages and Content Cards (nuget: [Braze.iOS.BrazeUI](https://www.nuget.org/packages/Braze.iOS.BrazeUI)).
    - **BrazeLocation**: Location library providing support for location analytics and geofence monitoring (nuget: [Braze.iOS.BrazeLocation](https://www.nuget.org/packages/Braze.iOS.BrazeLocation)).
    - **BrazeKitCompat**: Compatibility library with support for pre-4.0.0 APIs (nuget: [Braze.iOS.BrazeKitCompat](https://www.nuget.org/packages/Braze.iOS.BrazeKitCompat)).
    - **BrazeUICompat**: Compatibility library with support for pre-4.0.0 UI APIs (nuget: [Braze.iOS.BrazeUICompat](https://www.nuget.org/packages/Braze.iOS.BrazeUICompat)).
  - This migration requires re-identifying users. To do so, you must call the `changeUser` method on the Braze instance for non-anonymous users. You can read more about it [here](https://braze-inc.github.io/braze-swift-sdk/documentation/braze/appboy-migration-guide/#Re-identify-users).
  - Refer to the _BrazeiOSMauiSampleApp_ for the new integration, and to _BrazeiOSMauiCompatSampleApp_ for usage of the compatibility modules.
- Updated the iOS binding to the [Braze Swift SDK 7.6.0](https://github.com/braze-inc/braze-swift-sdk/releases/tag/7.6.0)
- The iOS binding requires using .NET 7 for compatibility with Xcode 15.

## 3.0.0

##### Breaking
- The NuGet package has been renamed from `AppboyPlatformXamariniOSBinding` to [`BrazePlatform.BrazeiOSBinding`](https://www.nuget.org/packages/BrazePlatform.BrazeiOSBinding/).
  - To use the updated package, replace any instances of `using AppboyPlatformXamariniOSBinding;` with:
  ```
  using Braze;
  ```
- This version requires using .NET 6+ and removes support for projects using the Xamarin framework. See [Microsoft's policy](https://dotnet.microsoft.com/en-us/platform/support/policy/xamarin) around the end of support for Xamarin.
- Updated the Android binding from [Braze Android SDK 26.3.2 to 29.0.1](https://github.com/braze-inc/braze-android-sdk/compare/v26.3.1...v29.0.1#diff-06572a96a58dc510037d5efa622f9bec8519bc1beab13c9f251e97e657a9d4ed).

##### Fixed
- Fixed an issue where some Android `set` methods were being hidden by the Xamarin framework.

##### Added
- Added support for .NET 6 (or newer) and support for projects using [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-8.0).
  - For a reference iOS implementation, see `BrazeiOSMauiSampleApp.sln`.
- Updated the iOS binding from [Braze iOS SDK 4.4.1 to 4.6.0](https://github.com/Appboy/appboy-ios-sdk/compare/4.4.1...4.6.0#diff-06572a96a58dc510037d5efa622f9bec8519bc1beab13c9f251e97e657a9d4ed).
  - The underlying iOS assets have been updated to use XCFrameworks:
    - `Appboy_iOS_SDK.framework` -> `Appboy_iOS_SDK.xcframework`
    - `SDWebImage.framework` -> `SDWebImage.xcframework`

## 2.0.1

##### Fixed
- Updated the Android binding to use [Braze Android SDK 26.3.2](https://github.com/braze-inc/braze-android-sdk/blob/master/CHANGELOG.md#2632).

## 2.0.0

> Starting with this release, this SDK will use [Semantic Versioning](https://semver.org/).

##### Breaking
- Updated the Android binding to use [Braze Android SDK 26.3.0](https://github.com/braze-inc/braze-android-sdk/blob/master/CHANGELOG.md#2630).

## 1.27.0

##### Added
- Added `BrazePlatform.BrazeAndroidBinding` which introduces .NET 6+ framework support for MAUI.
  - This package is available [here on Nuget](https://www.nuget.org/packages/BrazePlatform.BrazeAndroidBinding/).
- Updated the Android binding to use [Braze Android SDK 24.2.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#2420).

## 1.26.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 23.3.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#2330).

## 1.25.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 21.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#2100).

## 1.24.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 19.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1900).

## 1.23.0

##### Breaking
- Updated the iOS binding to use [Braze iOS SDK 4.4.1](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#441).
  - Added `AddToSubscriptionGroupWithGroupId` and `RemoveFromSubscriptionGroupWithGroupId` to `ABKUser`.
- Updated the Android binding to use [Braze Android SDK 18.0.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1801).
  - This introduces a hard dependency on `Xamarin.Kotlin.StdLib` in your package references.
  - This introduces a hard dependency on `Xamarin.KotlinX.Coroutines.Android` in your package references.

## 1.21.1

##### Changed
- Updated the iOS binding to use [Braze iOS SDK 4.3.2](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#432).

## 1.21.0

##### Breaking
- Updated the iOS binding to use [Braze iOS SDK 4.3.1](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#431).
  - This includes several breaking changes in the binding, and integrators should test before releasing. Please read the Braze iOS SDK changelog for details.

## 1.20.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 15.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1500).

## 1.19.0

##### Changed
- Updated the Android binding to use [Braze Android SDK 13.1.2](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1312).

## 1.18.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 13.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1300).
- Updated the iOS binding to use [Braze iOS SDK 3.33.1](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#3331).

## 1.17.0

##### Breaking
- Updated the iOS binding to use [Braze iOS SDK 3.29.1](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#3291).
- Updated the Android binding to use [Braze Android SDK 11.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1100).

## 1.16.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 10.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1000).

## 1.15.0

##### Breaking
- The native iOS bridge uses [Braze iOS SDK 3.27.0](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#3270). This release adds support for iOS 14 and requires XCode 12. Please read the Braze iOS SDK changelog for details.
- `ABKIDFADelegate.IsAdvertisingTrackingEnabled` has been renamed to `ABKIDFADelegate.IsAdvertisingTrackingEnabledOrATTAuthorized`.
- The class `ABKIdentifierForAdvertisingProvider` has been removed.

## 1.14.0

##### Breaking
- Updated the native iOS bridge to [Braze iOS SDK 3.26.1](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.26.1).

## 1.13.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 8.1.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#810).

## 1.12.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 8.0.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#801).
- Updated the native iOS bridge to [Braze iOS SDK 3.24.2](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.24.2).
  - Flipped `ABKLocationManager.DisableLocationTracking` to `ABKLocationManager.EnableLocationTracking`.
  - Replaced `ABKInAppMessageWindowController.supportedOrientationMasks` with `ABKInAppMessageWindowController.supportedOrientationMask`.
 
## 1.11.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 6.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#600).
- Changed the Android binding to target Android 10.

## 1.10.2

**Important:** This patch updates the Braze iOS SDK Dependency from 3.20.1 to 3.20.2, which contains important bugfixes. Integrators should upgrade to this patch version. Please see the [Braze iOS SDK Changelog](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md) for more information.

##### Changed
- Updated the native iOS bridge to [Braze iOS SDK 3.20.2](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.20.2).

## 1.10.1

**Important:** This release has known issues displaying HTML in-app messages. Do not upgrade to this version and upgrade to 1.10.2 and above instead. If you are using this version, you are strongly encouraged to upgrade to 1.10.2 or above if you make use of HTML in-app messages.

##### Changed
- Updated the native iOS bridge to [Braze iOS SDK 3.20.1](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.20.1).

## 1.10.0

**Important:** This release has known issues displaying HTML in-app messages. Do not upgrade to this version and upgrade to 1.10.2 and above instead. If you are using this version, you are strongly encouraged to upgrade to 1.10.2 or above if you make use of HTML in-app messages.

##### Breaking
- Updated the native iOS bridge to [Braze iOS SDK 3.20.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.20.0).
- **Important:** Braze iOS SDK 3.20.0 contains updated push token registration methods. We recommend upgrading to these methods as soon as possible to ensure a smooth transition as devices upgrade to iOS 13. In `application.RegisteredForRemoteNotifications:`, replace
```
Appboy.SharedInstance?.RegisterPushToken(deviceToken.ToString());
```
with
```
Appboy.SharedInstance?.RegisterDeviceToken(deviceToken);
```

## 1.9.0

**Important:** This release has known issues displaying HTML in-app messages. Do not upgrade to this version and upgrade to 1.10.2 and above instead. If you are using this version, you are strongly encouraged to upgrade to 1.10.2 or above if you make use of HTML in-app messages.

##### Breaking
- Updated the Android binding to use [Braze Android SDK 3.7.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#370).
- Updated the native iOS bridge to [Braze iOS SDK 3.19.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.19.0).
- Note: This Braze Xamarin SDK release updates to Braze Android SDK and Braze iOS SDK dependencies which no longer enable automatic Braze location collection by default. Please consult their respective changelogs for information on how to continue to enable automatic Braze location collection, as well as further information on breaking changes.
- Removes the Feedback feature as well as all associated methods, classes, and interfaces.

## 1.8.0

##### Changed
- Updated the Android binding to use [Braze Android SDK 3.3.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#330).

##### Added
- Added C# bindings for Braze Android SDK classes with Firebase Cloud Messaging dependencies.

## 1.7.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 3.2.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#321).
  - Added `AppboyFirebaseMessagingService` to directly use the Firebase messaging event `com.google.firebase.MESSAGING_EVENT`. This is now the recommended way to integrate Firebase push with Braze. The `AppboyFcmReceiver` should be removed from your `AndroidManifest` and replaced with the following:
    ```
    <service android:name="com.appboy.AppboyFirebaseMessagingService">
    <intent-filter>
    <action android:name="com.google.firebase.MESSAGING_EVENT" />
    </intent-filter>
    </service>
    ```
  - Also note that any `c2dm` related permissions should be removed from your manifest as Braze does not require any extra permissions for `AppboyFirebaseMessagingService` to work correctly.
- Updated the native iOS bridge to [Braze iOS SDK 3.14.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.14.0).
  - Drops support for iOS 8.
  - Removes Cross-Promotion cards from the News Feed. 

## 1.6.0

##### Breaking
- Updated the native iOS bridge to [Braze iOS SDK 3.11.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.11.0).
- Updated the Android binding to use [Braze Android SDK 3.0.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#301).

## 1.5.2

##### Breaking
- Updated the Android binding to use [Braze SDK version 2.5.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#250).

##### Fixed
- Fixed an issue that caused C# bindings to not be generated for certain classes in the Braze UI library.

##### Changed
- Updated the Android sample app to use Firebase Cloud Messaging (FCM).

## 1.5.1

##### Changed
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 3.3.4](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.3.4).
  - Added `DisableSDK()` and `RequestEnableSDKOnNextAppRun()` to the `Appboy` interface to disable and re-enable the Braze SDK.
  - Added `WipeDataAndDisableForAppRun()` on the `Appboy` interface to support wiping all customer data created by the Braze SDK.
  - Note that methods that disable the SDK will cause `Appboy.SharedInstance` to return `null`. If you have code that uses `Appboy.SharedInstance`, do not use `DisableSDK()` or `WipeDataAndDisableForAppRun()` until your code can safely execute even if `Appboy.SharedInstance` is null.
- Updated the Android binding to use [Braze SDK version 2.2.5](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#225).
  - Added `DisableSdk()` and `EnableSdk()` to the `Appboy` interface to disable and re-enable the Braze SDK.
  - Added `WipeData()` on the `Appboy` interface to support wiping all customer data created by the Braze SDK.

## 1.5

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 3.3.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.3.0).
- Updated the Android binding to use [Braze SDK version 2.2.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#221).
- Removed the need to include `Appboy.bundle` manually in iOS integrations. Integrators should remove existing `Appboy.bundle` files from their iOS integrations.

##### Added
- Added the ability to report to Braze that the app is running Xamarin to iOS integrations. We strongly recommend reporting this value to allow Braze to calculate accurate usage around different SDK platforms. To enable reporting, add `Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;` to your `AppDelegate.cs` after calling `Appboy.StartWithApiKey()`.
- Braze Xamarin Bindings are now available on [Nuget](nuget.org). Check out our [iOS Binding](https://www.nuget.org/packages/AppboyPlatformXamariniOSBinding/) and [Android Binding](https://www.nuget.org/packages/AppboyPlatform.AndroidBinding/). Note that Braze Xamarin SDK version `1.5.0` is the last version to receive a Xamarin component store release. Future releases will be released to Nuget and the open source repo only.

## 1.4

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.29.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.29.0).
- Updated the Android binding to use [Braze SDK version 2.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#200).

## 1.3

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.24.2](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.24.2).
- Updated the Android binding to use [Braze SDK version 1.15.3](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1153).
- **Update Required** — Updated iOS push handling in the AppboyProject sample project to be compatible with iOS 10. For more information, refer to the CHANGELOG for [Braze iOS SDK v2.24.0](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#2240).

##### Changed
- Updated the AppboyProject sample project to integrate session handling and in-app message manager registration using an [AppboyLifecycleCallbackListener](https://github.com/Appboy/appboy-android-sdk/blob/master/android-sdk-ui/src/com/appboy/AppboyLifecycleCallbackListener.java), as introduced in Braze Android SDK v1.15.0.

##### Removed
- Removed `AppboyBroadcastReceiver.cs` from the AppboyProject sample project, as Braze Android SDK v1.15.0 removes the need for a custom `AppboyBroadcastReceiver` for Braze push notifications.

## 1.2

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.17.1](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.17.1).
- Updated the Android binding to use [Braze SDK version 1.11.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1110).

## 1.1

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.12.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.12.0).
- Updated the Android binding to use [Braze SDK version 1.8.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#180).

##### Added
- Added a Xamarin Forms sample application with News Feed integrations.
- Added AppboyXamarinFormsFeedFragment that inherits from Android.App.Fragment to be compatible with Xamarin Forms.

## 1.0

##### Added
- Added support for all standard API and UI functionality in the Android SDK and iOS SDKs.
- iOS functionality not included in this release: IDFA collection, custom Slideup viewControllers, social data collection.
- Please contact support@braze.com for more information about these features and the timeline for their inclusion.
