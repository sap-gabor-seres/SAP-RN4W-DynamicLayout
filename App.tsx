/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow strict-local
 */

import React from 'react';
import {StyleSheet,	View} from 'react-native';
import { MultilineTextBoxComponent, MyListViewComponent } from './NativeComponents';

const App: () => JSX.Element = () => {
	return (
			<View style={styles.container}>
                <MultilineTextBoxComponent />
				{/* <MyListViewComponent /> */}
            </View>
	);
};

const styles = StyleSheet.create({
	container: {
        //flex: 1,
        //justifyContent: 'space-around',
        //alignItems: 'stretch',
		//alignContent: 'stretch'
    }
});

export default App;
