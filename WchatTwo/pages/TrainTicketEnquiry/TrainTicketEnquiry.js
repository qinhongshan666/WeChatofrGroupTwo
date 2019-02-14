// pages/TrainTicketEnquiry/TrainTicketEnquiry.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    list: [],
    startDate: '',
    Sweek: '',
    hidden: true,
    BeginSite: '',  //出发地
    ArriveSite: '',  //终点





  },

  onLoad: function (options) {
    var BeginSite = options.BeginSite;
    var ArriveSite = options.ArriveSite;

    var that = this;
    wx.request({
      url: 'http://localhost:61984/api/TrainInfo/GetTrainInfo', // 仅为示例，并非真实的接口地址
      method: 'get',
      data: {
        BeginSite: BeginSite,
        ArriveSite: ArriveSite

      },
      success(res) {
        console.log(res);
        that.setData({
          list: res.data,
        })
      }
    })
    this.setData({
      BeginSite: BeginSite,
      ArriveSite: ArriveSite

    })
  },

  bindDateChange: function (e) {
    wx.request({
      url: 'http://localhost:61984/api/TrainInfo/GetTrainInfo', // 仅为示例，并非真实的接口地址
      method: 'GET',
      data: {
        BeginSite: this.data.BeginSite,
        ArriveSite: this.data.ArriveSite

      },
      success(res) {
        that.setData({
          list: res.data,
        })
      }
    })
    this.setData({
      BeginTime: e.detail.value
    })
  },
  onReady: function () {
    this.animation = wx.createAnimation({
      timingFunction: "ease",
      duration: 400,

    })
  },

  // 火车票订页面
  go: function (ev) {
    var ID = ev.currentTarget.id;
    wx.navigateTo({
      url: '../Trainticketdetails/Trainticketdetails?ID=' + ID,
    })
  },

})