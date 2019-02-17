// pages/airticket/airticket.js

Page({
  data: {
    list: [],
    starDate: '',
    Sweek: '',
    hidden: true,
    leavecity: '',
    arrivecity: '',

  },

  onLoad: function (options) {
    var leavecity = options.region;
    var arrivecity = options.regions;
    var that = this;
    wx.request({
      url: 'http://localhost:61984/api/Bus/ShowBus',
      method: 'GET',
      data: {
        leavecity: leavecity,
        arrivecity: arrivecity,
      },
      success(res) {
        that.setData({
          list: res.data,
        })
      }
    })
    this.setData({
      leavecity: leavecity,
      arrivecity: arrivecity,
    })
  },

  bindDateChange: function (a) {
    wx.request({
      url: 'http://localhost:61984/api/Bus/GetBus',
      method: 'GET',
      data: {
        leaveCity: this.data.leavecity,
        arriveCity: this.data.arrivecity,
      },
      success: function (res) {
        that.setData({
          list: res.data,
        })

      }
    })
    this.setData({
      dateday: a.detail.value
    })
  },
  onReady: function () {
    this.animation = wx.createAnimation({
      timingFunction: "ease",
      duration: 400,

    })
  },

  go: function (ev) {
    console.log(ev);
    var busid = ev.currentTarget.id;
    wx.navigateTo({
      url: '../Bus_details/Bus_details?busid=' + busid,
    })
  },

  bt:function()
  {
     wx.navigateTo({
       url: '../ checkBus / checkBus',
     })

  }
})
