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
    var state=0;
    var that = this.data;
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
        OrderState:state,

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
  },



 toPays: function () {
   var state = 1;
    var that = this.data;
      console.log(that.startDate)
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