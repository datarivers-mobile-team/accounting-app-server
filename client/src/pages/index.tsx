import { BrowserRouter as Router, Navigate, Route, Routes } from 'react-router-dom';
import AppRouter from './home';
import AuthRouter from './auth';


export const RouteManager = () => {
	return (
		<Router>
			<Routes>
				<Route path="/*" element={<Navigate to='/auth/login' />} />
				<Route path="auth/*" element={<AuthRouter />} />
				<Route path="app/*" element={<AppRouter />} />
      </Routes>
		</Router>
	);
};
