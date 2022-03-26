import { YMaps, Map as YMap, Placemark } from 'react-yandex-maps'
import { renderToString } from 'react-dom/server'
import { Baloon } from './MapBaloons'

const mapData = {
  // Координаты центра карты.
  // Порядок по умолчанию: «широта, долгота».
  // Чтобы не определять координаты центра карты вручную,
  // воспользуйтесь инструментом Определение координат.
  center: [43.414707, 39.949854],
  // Уровень масштабирования. Допустимые значения:
  // от 0 (весь мир) до 19.
  zoom: 15,
  behaviors: ['default', 'scrollZoom'],
}

const getPlacemark = (places) => {
  return places.map((p, index) => (
    <Placemark
    key={index}
      geometry={[
        p.address.geolocation.geographicCoordinates.latitude,
        p.address.geolocation.geographicCoordinates.longitude,
      ]}
      properties={{ balloonContent: renderToString(<Baloon data={p} />) }}
    />
  ))
}

const Map = (props) => {
  return (
    <div className="map-container">
      <YMaps>
        <YMap
          defaultState={mapData}
          modules={[
            'package.full',
            'geoObject.addon.balloon',
            'geoObject.addon.hint',
          ]}
          width="auto"
          height="700px"
        >
          {getPlacemark(props.data.branches)}
          {getPlacemark(props.data.devices)}
        </YMap>
      </YMaps>
    </div>
  )
}

export default Map
