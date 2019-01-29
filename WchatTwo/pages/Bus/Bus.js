// pages/Bus/Bus.js

Page({


  /**
   * 页面的初始数据
   */
  data: {
    array: ['美国', '中国', '巴西', '日本'],

    index: 0,
    indexs: 0,



    date: '2019-01-01',
    region: ['广东省', '广州市', '海珠区'],
    customItem: '全部',
        region1: ['广东省', '广州市', '海珠区'],

  },
  bindPickerChange: function (e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      index: e.detail.value
    })
  },
  bindPickerChanges: function (e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      indexs: e.detail.value
    })
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
  bindRegionChange1: function (e) {
    console.log('picker发送选择改变，携带值为', e.detail.value)
    this.setData({
      region1: e.detail.value
    })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
   
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  },
//购票信息
  navigateDetail:function(){
    wx.navigateTo({
      url: '../Airport_bus/Airport_bus'
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
  }
})