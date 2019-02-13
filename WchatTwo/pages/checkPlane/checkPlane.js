// pages/checkBus/checkBus.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

    navbar: ["已完成", "代付款", "退款中"],
    currentTab: 0,
  },


  // bindChange:function(e)
  // {
  //   var that=this;
  //   that.setData({currentTab:e.detail.current});
  // },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
    wx.request({
      url: 'http://localhost:61984/api/ShoppingCart/GetPaid',
      dataType: 'json',
      method: 'get',
      async: false,
      success: function (options) {
        console.log(options.data);
        that.setData({
          infos: options.data,
        })
      }

    }),
    wx.request({
      url: 'http://localhost:61984/api/ShoppingCart/GetObligation',
      dataType:'json',
      method:'get',
      async: false,
      success:function(options){
console.log(options.data)
that.setData({
  loading:options.data,
  
})
      }
    }),
      wx.request({
      url: 'http://localhost:61984/api/ShoppingCart/GetNonPayment',
        dataType: 'json',
        method: 'get',
        async: false,
        success: function (options) {
          console.log(options.data)
          that.setData({
            baclk: options.data,

          })
        }
      })




  },
  bindChange: function (e) {

    var that = this;
    that.setData({ currentTab: e.detail.current });

  },
  navbarTap: function (e) {
    this.setData({
      currentTab: e.currentTarget.dataset.idx
    })
  },
  /**
   * 点击tab切换
   */
  swichNav: function (e) {

    var that = this;

    if (this.data.currentTab === e.target.dataset.current) {
      return false;
    } else {
      that.setData({
        currentTab: e.target.dataset.current
      })
    }
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

  }
})