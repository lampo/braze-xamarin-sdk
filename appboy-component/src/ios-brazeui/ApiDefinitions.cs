using System;
using BrazeKit;
using BrazeUI;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using WebKit;

namespace BrazeUI
{
	// @interface AsyncImageView : UIView
	[BaseType (typeof(UIView), Name = "_TtC7BrazeUI14AsyncImageView")]
	interface AsyncImageView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

	}

	// @interface BrazeInAppMessageUI : NSObject <BrazeInAppMessagePresenter>
	[BaseType (typeof(NSObject))]
	interface BrazeInAppMessageUI
	{
		// -(void)presentMessage:(BRZInAppMessageRaw * _Nonnull)message;
		[Export ("presentMessage:")]
		void PresentMessage (BRZInAppMessageRaw message);

		// -(void)presentNext;
		[Export ("presentNext")]
		void PresentNext ();

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion ([NullAllowed] Action completion);

		// -(void)_compat_tryPushOnStack:(BRZInAppMessageRaw * _Nonnull)message;
		[Export ("_compat_tryPushOnStack:")]
		void _compat_tryPushOnStack (BRZInAppMessageRaw message);

		//  (readonly, nonatomic, strong) UIView * _Nullable messageView;
		[NullAllowed, Export ("messageView", ArgumentSemantic.Strong)]
		UIView MessageView { get; }

		//  (readonly, copy, nonatomic) NSArray<BRZInAppMessageRaw *> * _Nonnull stack;
		[Export ("stack", ArgumentSemantic.Copy)]
		BRZInAppMessageRaw[] Stack { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BrazeInAppMessageUIDelegate Delegate { get; set; }

		//  (nonatomic, weak) id<BrazeInAppMessageUIDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();
	}

	// @interface BRZUIResources : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZUIResources
	{
		// @property (readonly, nonatomic, strong, class) NSBundle * _Nullable bundle;
		[Static]
		[NullAllowed, Export ("bundle", ArgumentSemantic.Strong)]
		NSBundle Bundle { get; }

		// @property (readonly, copy, nonatomic, class) NSDictionary<NSString *,NSURL *> * _Nonnull acknowledgments;
		[Static]
		[Export ("acknowledgments", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSUrl> Acknowledgments { get; }

	}
	// @interface BRZContentCardUIModalViewController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	[DisableDefaultCtor]
	interface BRZContentCardUIModalViewController
	{
		// @property (readonly, nonatomic, strong) BRZContentCardUIViewController * _Nonnull viewController;
		[Export ("viewController", ArgumentSemantic.Strong)]
		BRZContentCardUIViewController ViewController { get; }
		// -(void)dismissModal;
		[Export ("dismissModal")]
		void DismissModal ();

		// -(instancetype _Nonnull)initWithBraze:(Braze * _Nonnull)braze;
		[Export ("initWithBraze:")]
		NativeHandle Constructor (Braze braze);

		// -(instancetype _Nonnull)initWithBraze:(Braze * _Nonnull)braze title:(NSString * _Nonnull)title;
		[Export ("initWithBraze:title:")]
		NativeHandle Constructor (Braze braze, string title);
	}

	// @interface ShadowView : UIView
	[BaseType (typeof(UIView), Name = "_TtC7BrazeUI10ShadowView")]
	interface ShadowView
	{
	}

	// @interface BRZContentCardUIViewController : UITableViewController <UITableViewDataSourcePrefetching>
	[BaseType (typeof(UITableViewController))]
	[DisableDefaultCtor]
	interface BRZContentCardUIViewController : IUITableViewDataSourcePrefetching
	{

		// -(void)refreshCards;
		[Export ("refreshCards")]
		void RefreshCards ();

		//  (copy, nonatomic) NSArray<BRZContentCardRaw *> * _Nonnull cards;
		[Export ("cards", ArgumentSemantic.Copy)]
		BRZContentCardRaw[] Cards { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BrazeContentCardUIViewControllerDelegate Delegate { get; set; }

		//  (nonatomic, weak) id<BrazeContentCardUIViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithBraze:(Braze * _Nonnull)braze;
		[Export ("initWithBraze:")]
		NativeHandle Constructor (Braze braze);

	}

	// @interface BRZGIFViewProvider : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZGIFViewProvider
	{
		// @property (nonatomic, strong, class) BRZGIFViewProvider * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		BRZGIFViewProvider Shared { get; set; }

		// @property (copy, nonatomic) UIView * _Nonnull (^ _Nonnull)(NSURL * _Nullable) view;
		[Export ("view", ArgumentSemantic.Copy)]
		Func<NSUrl, UIView> View { get; set; }

		// @property (copy, nonatomic) void (^ _Nonnull)(UIView * _Nonnull, NSURL * _Nullable) updateView;
		[Export ("updateView", ArgumentSemantic.Copy)]
		Action<UIView, NSUrl> UpdateView { get; set; }

		// -(instancetype _Nonnull)initWithView:(UIView * _Nonnull (^ _Nonnull)(NSURL * _Nullable))view updateView:(void (^ _Nonnull)(UIView * _Nonnull, NSURL * _Nullable))updateView;
		[Export ("initWithView:updateView:")]
		NativeHandle Constructor (Func<NSUrl, UIView> view, Action<UIView, NSUrl> updateView);

		// +(BRZGIFViewProvider * _Nonnull)providerWithView:(UIView * _Nonnull (^ _Nonnull)(NSURL * _Nullable))view updateView:(void (^ _Nonnull)(UIView * _Nonnull, NSURL * _Nullable))updateView __attribute__((warn_unused_result("")));
		[Static]
		[Export ("providerWithView:updateView:")]
		BRZGIFViewProvider ProviderWithView (Func<NSUrl, UIView> view, Action<UIView, NSUrl> updateView);

		// @property (readonly, nonatomic, strong, class) BRZGIFViewProvider * _Nonnull nonAnimating;
		[Static]
		[Export ("nonAnimating", ArgumentSemantic.Strong)]
		BRZGIFViewProvider NonAnimating { get; }

	}

	// @protocol BrazeContentCardUIViewControllerDelegate
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface BrazeContentCardUIViewControllerDelegate
	{
		// @optional -(BOOL)contentCardController:(BRZContentCardUIViewController * _Nonnull)controller shouldProcess:(NSURL * _Nonnull)url card:(BRZContentCardRaw * _Nonnull)card __attribute__((warn_unused_result("")));
		[Export ("contentCardController:shouldProcess:card:")]
		bool ShouldProcess (BRZContentCardUIViewController controller, NSUrl url, BRZContentCardRaw card);

	}

	// @protocol BrazeInAppMessageUIDelegate
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface BrazeInAppMessageUIDelegate
	{
		// @optional -(enum BRZInAppMessageUIDisplayChoice)inAppMessage:(BrazeInAppMessageUI * _Nonnull)ui displayChoiceForMessage:(BRZInAppMessageRaw * _Nonnull)message __attribute__((warn_unused_result("")));
		[Export ("inAppMessage:displayChoiceForMessage:")]
		BRZInAppMessageUIDisplayChoice DisplayChoiceForMessage (BrazeInAppMessageUI ui, BRZInAppMessageRaw message);

		// @optional -(void)inAppMessage:(BrazeInAppMessageUI * _Nonnull)ui willPresent:(BRZInAppMessageRaw * _Nonnull)message view:(UIView * _Nonnull)view;
		[Export ("inAppMessage:willPresent:view:")]
		void WillPresent (BrazeInAppMessageUI ui, BRZInAppMessageRaw message, UIView view);

		// @optional -(void)inAppMessage:(BrazeInAppMessageUI * _Nonnull)ui didPresent:(BRZInAppMessageRaw * _Nonnull)message view:(UIView * _Nonnull)view;
		[Export ("inAppMessage:didPresent:view:")]
		void DidPresent (BrazeInAppMessageUI ui, BRZInAppMessageRaw message, UIView view);

		// @optional -(void)inAppMessage:(BrazeInAppMessageUI * _Nonnull)ui willDismiss:(BRZInAppMessageRaw * _Nonnull)message view:(UIView * _Nonnull)view;
		[Export ("inAppMessage:willDismiss:view:")]
		void WillDismiss (BrazeInAppMessageUI ui, BRZInAppMessageRaw message, UIView view);

		// @optional -(void)inAppMessage:(BrazeInAppMessageUI * _Nonnull)ui didDismiss:(BRZInAppMessageRaw * _Nonnull)message view:(UIView * _Nonnull)view;
		[Export ("inAppMessage:didDismiss:view:")]
		void DidDismiss (BrazeInAppMessageUI ui, BRZInAppMessageRaw message, UIView view);

		// @optional -(BOOL)inAppMessage:(BrazeInAppMessageUI * _Nonnull)ui shouldProcess:(enum BRZInAppMessageRawClickAction)clickAction url:(NSURL * _Nullable)url buttonId:(NSString * _Nullable)buttonId message:(BRZInAppMessageRaw * _Nonnull)message view:(UIView * _Nonnull)view __attribute__((warn_unused_result("")));
		[Export ("inAppMessage:shouldProcess:url:buttonId:message:view:")]
		bool ShouldProcess (BrazeInAppMessageUI ui, BRZInAppMessageRawClickAction clickAction, [NullAllowed] NSUrl url, [NullAllowed] string buttonId, BRZInAppMessageRaw message, UIView view);

	}
}
