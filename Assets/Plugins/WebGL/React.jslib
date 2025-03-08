mergeInto(LibraryManager.library, {
  SetScore: function (score) {
    window.dispatchReactUnityEvent("SetScore", score);
  },
});
