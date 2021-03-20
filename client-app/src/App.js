import './App.css';
import { Switch, Route } from 'react-router-dom';

import Layout from './layout/Layout.component';
import Homepage from './pages/homepage/Homepage.page'
import Cart from './pages/cart/Cart.page'
import ThankYou from './pages/thank-you/ThankYou.page'

function App() {
  return (
    <Layout>
      <div className='App'>
        <Switch>
          <Route exact path='/' component={Homepage} />
          <Route exact path='/cart' component={Cart} />
          <Route exact path='/thankyou' component={ThankYou} />

        </Switch>
      </div>
    </Layout>
  );
}

export default App;
