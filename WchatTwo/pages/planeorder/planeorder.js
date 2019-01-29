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

    startDate: '',
    date: '',
    Sweek: '',
    hidden: true,
    leavecity:'',
    arrivecity:'',
    dateday:'',
  },

  onLoad: function (options) {
    var leavecity=options.region;
    var arrivecity = options.regions;
    var dateday = options.date;
    wx.request({
      url: 'http://localhost:61272/api/Default/PlaneIndex', // 仅为示例，并非真实的接口地址
      method: 'GET',
      data: {
        leaveCity: leavecity,
        arriveCity: arrivecity,
        dateDay: dateday
      },
      header: {
        'content-type': 'application/json' // 默认值
      },
      success(res) {
        console.log(res.data)
      }
    })
    this.setData({
      leavecity: leavecity,
      arrivecity: arrivecity,
      dateday: dateday,
    })
  },

  bindDateChange: function (e) {
    wx.request({
      url: 'http://localhost:61272/api/Default/PlaneIndex', // 仅为示例，并非真实的接口地址
      method: 'GET',
      data: {
        leaveCity: this.data.leavecity,
        arriveCity: this.data.arrivecity,
        dateDay: this.data.dateday
      },
      header: {
        'content-type': 'application/json' // 默认值
      },
      success(res) {
        console.log(res.data)
      }
    })
    this.setData({
      dateday: e.detail.value
    })
  },
  onReady: function () {
    this.animation = wx.createAnimation({
      timingFunction: "ease",
      duration: 400,

    })
  },

  // 机票预订页面
  go: function (ev) {
    wx.navigateTo({
      url: '../planedetails/planedetails',
    })
  },

})