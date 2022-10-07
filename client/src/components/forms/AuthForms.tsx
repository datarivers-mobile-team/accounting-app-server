import { LOGIN_FIELDS, LOGIN_INITIAL_VALUES, LOGIN_VALIDATOR } from 'constants';
import React from 'react';
import { useNavigate } from 'react-router-dom';
import { Generator } from './Generator';

export const LoginForm = () => {
	const navigator = useNavigate();
	return (
		<Generator
			fields={LOGIN_FIELDS}
			initialValues={LOGIN_INITIAL_VALUES}
			validator={LOGIN_VALIDATOR}
			submit={() => navigator('/app')}
			submitBtn="Login"
		/>
	);
};
