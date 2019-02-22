// pages/airticket/airticket.js

Page({
  data: {
    list: [],
    startDate: '',
    date: '',
    Sweek: '',
    hidden: true,
    leavecity: '',
    arrivecity: '',
    dateday: '',
    nodata:'',
  },

  onLoad: function (options) {
    var leavecity = options.region;
    var arrivecity = options.regions;
    var dateday = options.date;
    var that = this;
    wx.request({
      url: 'http://localhost:61984/api/Plane/GetPlanes', // 仅为示例，并非真实的接口地址
      method: 'get',
      data: {
        leaveCity: leavecity,
        arriveCity: arrivecity,
        dateDay: dateday
      },
      success(res) {
        if(res.data.length==0){
          that.setData({
            nodata:'暂无数据'
          })
        }
        else{
          that.setData({
            list: res.data,
          })
        }
        
      }
    })
    this.setData({
      leavecity: leavecity,
      arrivecity: arrivecity,
      dateday: dateday,
    })
  },

  bindDateChange: function (e) {
    this.setData({
      dateday: e.detail.value
    })
    var that=this;
    wx.request({
      url: 'http://localhost:61984/api/Plane/GetPlanes', // 仅为示例，并非真实的接口地址
      method: 'GET',
      data: {
        leaveCity: this.data.leavecity,
        arriveCity: this.data.arrivecity,
        dateDay: this.data.dateday
      },
      success(res) {
        if (res.data.length == 0) {
          that.setData({
            nodata: '暂无数据',
            list: res.data,
          })
        }
        else {
          that.setData({
            nodata: '',
            list: res.data,
          })
        }
      }
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
    var planeid = ev.currentTarget.id;
    wx.navigateTo({
      url: '../planedetails/planedetails?planeid=' + planeid,
    })
  },

})