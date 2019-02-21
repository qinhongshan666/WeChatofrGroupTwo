// pages/Bus_details/Bus_details.js
const app = getApp();
Page({

  data: {

    ticket: 1,
    busPrice: '',
    startingStation: '',
    destinationStation: '',
    startDate: '',
    startTime: '',
    endTime: '',
    count: '',
    name: '',
    phone: '',
    idnumber: '',
    state:'',
    
  },

  onLoad: function (options) {
    var id = options.busid;
    var that = this;

    wx.request({
      url: 'http://localhost:61984/api/Bus/GetBus',
      method: 'GET',
      data: {
        id: id
      },
      success(res) {
        var list = res.data;
        that.setData({
          busPrice: list.BusPrice,
          startingStation: list.StartingStation,
          destinationStation: list.DestinationStation,
          startDate: list.StartDate,
          startTime: list.StartTime,
          endTime: list.EndTime,
          count: list.Count,

        })
      }
    })
  },


  toPay: function () {
    var state = 0;
    var that = this.data;
 
    console.log(that.count);
    wx.getStorage({
      key: 'token',
      success: function (res) {
        wx.request({
          url: 'http://localhost:61984/api/Bus/addbuss',
          method: 'POST',
          data: {
            BusPrice: that.busPrice,
            StartingStation: that.startingStation,
            DestinationStation: that.destinationStation,
            StartDate: that.startDate,
            StartTime: that.startTime,
            EndTime: that.endTime,
            Count: that.count,
            OrderState: state,
            Name:that.name,
            Phone:that.phone,
            IDnumber:that.idnumber
          },
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success(res) {
            var i = res.data;
            if (i == 1) {
              wx.navigateTo({
                url: '../checkBus/checkBus',
              })
            }
          }
        })
      }
    })
  },


  toPays: function () {
    var state = 1;
    var that = this.data;
    console.log(that.busPrice),
    wx.getStorage({
      key: 'token',
      success: function (res) {
        wx.request({
          url: 'http://localhost:61984/api/Bus/addbuss',
          method: 'POST',
          
          data: {
            BusPrice: that.busPrice,
            StartingStation: that.startingStation,
            DestinationStation: that.destinationStation,
            StartDate: that.startDate,
            StartTime: that.startTime,
            EndTime: that.endTime,
            Count: that.count,
            OrderState: state,
            Name: that.name,
            Phone: that.phone,
            IDnumber: that.idnumber
          },
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success(res) {
            var i = res.data;
            if (i == 1) {
              wx.navigateTo({
                url: '../checkBus/checkBus',
              })
            }
          }
        })
      }
    })
  },

  ticPhone: function (e) {
    this.setData({
      phone: e.detail.value,
    })
  },

  ticName: function (e) {
    this.setData({
      name: e.detail.value,
    })
  },

  ticidnumber: function (e) {
    this.setData({
      idnumber: e.detail.value,
    })
  },
    
    })