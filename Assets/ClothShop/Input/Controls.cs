public static class Controls {
  private static ControlsAsset _asset;
  public static ControlsAsset Asset {
    get {
      if (_asset == null) {
        _asset = new ControlsAsset();
        _asset.Enable();
      }
      return _asset;
    }
  }
  public static ControlsAsset.MotionActions Motion { get => Asset.Motion; }
  public static ControlsAsset.InteractionsActions Interactions { get => Asset.Interactions; }
  public static ControlsAsset.MenuActionsActions MenuActions { get => Asset.MenuActions; }
}
