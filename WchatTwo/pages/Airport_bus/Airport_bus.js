// pages/airticket/airticket.js

Page({
  data: {
    list1: [{
      id: 0,
      list2: [{}, {}, {}, {}]
    }, {
      id: 1,
      list2: [{}, {}, {}, {}]
    }, {
      id: 2,
      list2: [{}, {}]
    }, {}, {}, {}, {}, {}],

  
  },

  onLoad: function (options) {
    this.setData({
      hidden: true,
    })

  },

  onShow: function () {
    // 页面显示

  },
  onHide: function () {
    // 页面隐藏
  },
  onUnload: function () {
    // 页面关闭
  },
  onReady: function () {
    this.animation = wx.createAnimation({
      timingFunction: "ease",
      duration: 400,

    })
  },

  info: function () {
    wx.navigateTo({
      url: '../Bus_details/Bus_details'
    })
  }

})
