// pages/Trainticketdetails/Trainticketdetails.js

//获取应用实例
const app = getApp();

Page({

  /**
   * 页面的初始数据
   */
  data: {
    ticket: 1,
    TrainNumber: '', //火车车次
    BeginTime: '', //出发时间
    BeginSite: '', //出发地
    ArriveTime: '', //到站时间
    ArriveSite: '', //终点




    
    SeatGrade: '', //座位等级
    Price: '', //价格
    SurplusTicket: '', //余票
    SumMoney: '', //总金额
    Iphone: '', //手机号
    UserName: '', //用户名
    OrdersState: 0, //订单状态
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var ID = options.ID;
    var that = this;

    wx.request({
      url: 'http://localhost:61984/api/TrainInfo/FindTrain',
      method: 'GET',
      data: {
        id: ID
      },
      success(res) {
        var list = res.data;
        that.setData({
          TrainNumber: list.TrainNumber,
          BeginTime: list.BeginTime,
          BeginSite: list.BeginSite,
          ArriveTime: list.ArriveTime,
          ArriveSite: list.ArriveSite,
          SeatGrade: list.SeatGrade,
          Price: list.Price,
          SurplusTicket: list.SurplusTicket,
          SumMoney: list.Price,
        })
      }

    })
  },

  Plus() {
    var tic = this.data.ticket + 1;
    var unitprice = this.data.Price;
    this.setData({
      ticket: tic,
      SumMoney: tic * unitprice,
    })
  },
  Min() {
    var tic = this.data.ticket - 1;
    var unitprice = this.data.Price;
    this.setData({
      ticket: tic,
      totalsum: tic * unitprice,
    })
  },
  ticNum: function (e) {
    var unitprice = this.data.Price;
    this.setData({
      ticket: e.detail.value,
      SumMoney: e.detail.value * Price,
    })
  },
  ticPhone: function (e) {
    this.setData({
      Iphone: e.detail.value,
    })
  },

  //订单支付
  toPay: function () {
    var that = this.data;
    var username = app.globalData.userInfo;
    console.log(that.BeginTime);
    wx.request({
      url: 'http://localhost:61984/api/TrainInfo/TrainOrderInfo',
      method: 'post',
      data: {
        TrainNumber: that.TrainNumber,
        BeginTime: that.BeginTime,
        BeginSite: that.BeginSite,
        ArriveTime: that.ArriveTime,
        ArriveSite: that.ArriveSite,
        SeatGrade: that.SeatGrade,
        Price: that.SumMoney,
        SumMoney: that.SumMoney,
        Iphone: that.Iphone,
        UserName: username.nickName,
        OrdersState: that.OrdersState,
      },
      success(res) {
        var i = res.data;
        if (i == 1) {
          wx.navigateTo({
            url: '../checkTrain/checkTrain',
          })
        }
      }
    })



  }











})