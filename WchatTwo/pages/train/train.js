// pages/train/train.js
var util = require('../../utils/util.js');
Page({

  /**
   * 页面的初始数据
   */
  data: {
    indicatorDots: true,
    vertical: false,
    autoplay: true,
    interval: 3000,
    duration: 2000,

    Times: '',
    BeginSite: ['', '北京西', ''],   
    ArriveSite: ['', '临汾', ''],

  },


  //选择出发的日期
  bindDateChange: function (e) {
    this.setData({
      Times: e.detail.value
    })
  },
  //选择出发地
  bindRegionChange: function(e) {
    this.setData({
      BeginSite: e.detail.value
    })
  },
  //选择终点地
  bindRegionChanges: function(e) {
    this.setData({
      ArriveSite: e.detail.value
    })
  },



  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function(options) {
    //获取当前系统时间
    var time = util.formatDate(new Date());
    this.setData({
      Times: time,
    });
  },


  /**setDateValue: function(num) {
    return num < 10 ? "0" + num : num;
  },
**/

  //选择城市   跳转到城市页面
  // city: function() {
  //   wx.navigateTo({
  //     url: '../switchcity/switchcity',
  //   })
  // },

  //明天  点击明天 时间加一天
  Tomorrow: function() {
    var dd = this.data.Times;
    var d = new Date(dd);
    d.setDate(d.getDate() + 1);
    var year = d.getFullYear()
    var month = d.getMonth() + 1
    var day = d.getDate()
    if (month < 10) {
      month = '0' + month;
    }
    if (day < 10) {
      day = '0' + day;
    }
    var de = year + '-' + month + '-' + day
    this.setData({
      Times: de,
    });
  },

  //查询
  cha() {
    wx.navigateTo({
      url: '../TrainTicketEnquiry/TrainTicketEnquiry?BeginSite=' + this.data.BeginSite[1] + "&ArriveSite=" + this.data.ArriveSite[1] + "&Times=" + this.data.Times,
    })
  },


  //地址切换设置
  rotate() {
    var that = this.data;
    var chufa;
    var daoda;
    chufa = that.BeginSite;
    daoda = that.ArriveSite;
    this.setData({
      BeginSite: daoda,
      ArriveSite: chufa
    })
  },

//急速抢票页面
QuicklyGrabTickets(){
  wx.navigateTo({
    url: '../QuicklyGrabTickets/QuicklyGrabTickets',
  })
},
//在线选座页面
OnlineOptions(){
  wx.navigateTo({
    url: '../OnlineOptions/OnlineOptions',
  })
},
//超值酒店页面
  Hotel_info() {
    wx.navigateTo({
      url: '../Hotel_info/Hotel_info',
    })
  },
  //一元夺宝页面
  Snatch() {
    wx.navigateTo({
      url: '../Snatch/Snatch',
    })
  },






})