// pages/planedetails/planedetails.js
//获取应用实例
const app = getApp();

Page({

  /**
   * 页面的初始数据
   */
  data: {
    planeID:0,
    ticket: 1,
    totalsum: '',
    phone: '',
    unitPrice: '',
    leaveCity: '',
    arriveCity: '',
    leaveDate: '',
    leaveTime: '',
    typeID: '',
    inventory: '',
    arriveTime: '',
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {

    var id = options.planeid;
    var that = this;
    wx.request({
      url: 'http://localhost:61984/api/Plane/GetPlane', // 仅为示例，并非真实的接口地址
      method: 'GET',
      data: {
        id: id
      },
      success(res) {
        var list = res.data;
        that.setData({
          unitPrice: list.UnitPrice,
          leaveCity: list.LeaveCity,
          arriveCity: list.ArriveCity,
          arriveTime: list.ArriveTime,
          inventory: list.Inventory,
          leaveDate: list.LeaveDate,
          leaveTime: list.LeaveTime,
          typeID: list.TypeID,
          totalsum: list.UnitPrice,
          planeID:id
        })
      }
    })
  },
  //付款
  toPay: function () {
    var that = this.data;
    var username = app.globalData.userInfo;
    console.log(444444444444);
    console.log(username.nickName);

    var orderState = 0;
    wx.getStorage({
      key: 'token',
      success: function (res) {
        wx.request({
          url: 'http://localhost:61984/api/Plane/AddPlaneOrder', // 仅为示例，并非真实的接口地址
          method: 'post',
          data: {
            OrderUnitPrice: that.unitPrice,
            OrderLeaveCity: that.leaveCity,
            OrderArriveCity: that.arriveCity,
            OrderArriveTime: that.arriveTime,
            OrderLeaveDate: that.leaveDate,
            OrderLeaveTime: that.leaveTime,
            OrderTypeID: that.typeID,
            OrderTotalsum: that.totalsum,
            OrderTicket: that.ticket,
            OrderPhone: that.phone,
            OrderState: orderState,
            AccountName: username.nickName,
            PlaneID: that.planeID
          },
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success(res) {
            var i = res.data;
            if (i == 1) {
              wx.navigateTo({
                url: '../checkPlane/checkPlane',
              })
            }
          }
        })
      }
    })
    
  },
  toSave: function () {
    var that = this.data;
    var username = app.globalData.userInfo;
    var orderState = 1;
    wx.getStorage({
      key: 'token',
      success: function (res) {
        wx.request({
          url: 'http://localhost:61984/api/Plane/AddPlaneOrder', // 仅为示例，并非真实的接口地址
          method: 'post',
          data: {
            OrderUnitPrice: that.unitPrice,
            OrderLeaveCity: that.leaveCity,
            OrderArriveCity: that.arriveCity,
            OrderArriveTime: that.arriveTime,
            OrderLeaveDate: that.leaveDate,
            OrderLeaveTime: that.leaveTime,
            OrderTypeID: that.typeID,
            OrderTotalsum: that.totalsum,
            OrderTicket: that.ticket,
            OrderPhone: that.phone,
            OrderState: orderState,
            AccountName: username.nickName,
            PlaneID: that.planeID
          },
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success(res) {
            var i = res.data;
            if (i == 1) {
              wx.navigateTo({
                url: '../checkPlane/checkPlane',
              })
            }
          }
        })
      }
    })
    
  },

  Plus() {
    var tic = this.data.ticket + 1;
    var unitprice = this.data.unitPrice;
    this.setData({
      ticket: tic,
      totalsum: tic * unitprice,
    })
  },
  ticNum: function (e) {
    var unitprice = this.data.unitPrice;
    this.setData({
      ticket: e.detail.value,
      totalsum: e.detail.value * unitprice,
    })
  },
  ticPhone: function (e) {
    this.setData({
      phone: e.detail.value,
    })
  }
})