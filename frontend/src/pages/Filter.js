import { Button, Switch, Tabs } from 'antd'
import { AppleOutlined, AndroidOutlined } from '@ant-design/icons'
import { useState } from 'react'
import axios from 'axios'

const { TabPane } = Tabs
const instance = axios.create({
  baseURL: "https://localhost:5001",
  withCredentials: false,
  headers: {
    'Access-Control-Allow-Origin' : '*',
    'Access-Control-Allow-Methods':'GET,PUT,POST,DELETE,PATCH,OPTIONS',
    }
});

const Filter = () => {
  const [wifi, setWifi] = useState(true);
  const onButtonClick =  () => {
    var res =  instance.get('map', { params: { wifi: wifi } });
    console.log(res)
  }
  return (
    <div className="filter-container">
      <Tabs
        defaultActiveKey="1"
        tabBarExtraContent={<Button type="primary" onClick={onButtonClick}>Найти</Button>}
      >
        <TabPane
          tab={
            <span>
              <AppleOutlined />
              Общее
            </span>
          }
          key="1"
        >
          <div className="filter-tab-content">
            <span>WI-FI </span>
            <Switch checked={wifi} onChange={() => setWifi(!wifi)}></Switch>
          </div>
        </TabPane>
        <TabPane
          tab={
            <span>
              <AndroidOutlined />
              Карты
            </span>
          }
          key="2"
        >
          Tab 2
        </TabPane>
        <TabPane
          tab={
            <span>
              <AndroidOutlined />
              Tab 3
            </span>
          }
          key="3"
        >
          Tab 3
        </TabPane>
      </Tabs>
    </div>
  )
}
export default Filter
