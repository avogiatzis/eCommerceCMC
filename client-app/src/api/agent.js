import axios from 'axios';

axios.defaults.baseURL = 'http://localhost:5000/api';

const responseBody = (response) => response.data;

const requests = {
  get: (url) => axios.get(url).then(responseBody),
  post: (url, body) => axios.post(url, body).then(responseBody),
  put: (url, body) => axios.put(url, body).then(responseBody),
  del: (url) => axios.delete(url).then(responseBody),
};

const Products = {
  list: () => requests.get('/products'),
};

const Order = {
  send: (body) => {
    const content = body.map((item) => ({
      product: {
        id: item.id,
        name: item.name,
        category: item.category,
        price: item.price,
      },
      quantity: item.quantity,
    }));
    console.log({ orderItems: content });
    return requests.post('/Order', { orderItems: content });
  },
};

const ShippingCost = {
  get: (cost) => requests.get(`ShippingCost?cost=${cost}`),
};

const agent = {
  Products,
  Order,
  ShippingCost,
};

export default agent;
