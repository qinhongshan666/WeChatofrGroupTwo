// pages/train/train.js
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

    date: '2019-01-01',
    BeginSite: ['北京西', '北京西', '海珠区'],
    ArriveSite: ['临汾', '临汾', '海珠区'],

  },
  bindDateChange: function(e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      date: e.detail.value
    })
  },
  bindRegionChange: function(e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      BeginSite: e.detail.value
    })
  },
  bindRegionChanges: function(e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      ArriveSite: e.detail.value
    })
  },



  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function(options) {



  },
  setDateValue: function(num) {
    return num < 10 ? "0" + num : num;
  },


  //选择城市   跳转到城市页面
  // city: function() {
  //   wx.navigateTo({
  //     url: '../switchcity/switchcity',
  //   })
  // },

  //明天
  Tomorrow: function() {
    var dd = this.data.date;
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
      date: de,
    });
  },

  //查询
  cha() {
    wx.navigateTo({
      url: '../TrainTicketEnquiry/TrainTicketEnquiry?BeginSite=' + this.data.BeginSite[1] + "&ArriveSite=" + this.data.ArriveSite[1] + "&date=" + this.data.date,
    })
  },
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
  }







})