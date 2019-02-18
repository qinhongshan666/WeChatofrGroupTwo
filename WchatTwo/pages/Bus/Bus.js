// pages/Bus/Bus.js

Page({


  /**
   * 页面的初始数据
   */
  data: {
    date: '',
    region: ['北京市', '北京市', '海珠区'],
    regions: ['上海市', '上海市', '海珠区'],

  },
  bindDateChange: function (e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      date: e.detail.value
    })
  },
  bindRegionChange: function (e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      region: e.detail.value
    })
  },
  bindRegionChanges: function (e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      regions: e.detail.value
    })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {


  },

  //购票信息
  navigateDetail: function () {
    wx.navigateTo({
      url: '../Airport_bus/Airport_bus?region=' + this.data.region[1] + "&regions=" + this.data.regions[1] + "&dat=" + this.data.date
    })
  },
  //购票列表
  bus: function () {
    wx.navigateTo({
      url: '../Airport_bus/Airport_bus'
    })
  },
  //景区
  area: function () {
    wx.navigateTo({
      url: '../Scenic_area/Scenic_area'
    })
  },
  //酒店
  hotel: function () {
    wx.navigateTo({
      url: '../Hotel/hotel'
    })
  },
 
  reverse:function(){
     var that=this.data;
     var item;
     var items;
     item=that.region;
     items=that.regions;
    this.setData({
      region:items,
      regions:item,
    })


  }
  
})