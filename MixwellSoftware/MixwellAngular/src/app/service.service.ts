import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { catchError, map, tap } from 'rxjs/operators';

import { Service } from './service';
import { MessageService } from './message.service';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class ServiceService {

  private serviceUrl = 'api/heroes';  // URL to web api

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  /** GET services from the server */
  getServices (): Observable<Service[]> {
    return this.http.get<Service[]>(this.serviceUrl)
      .pipe(
        tap(services => this.log(`fetched services`)),
        catchError(this.handleError('getServices', []))
      );
  }

  /** GET service by id. Return `undefined` when id not found */
  getServiceNo404<Data>(id: number): Observable<Service> {
    const url = `${this.serviceUrl}/?id=${id}`;
    return this.http.get<Service[]>(url)
      .pipe(
        map(services => services[0]), // returns a {0|1} element array
        tap(h => {
          const outcome = h ? `fetched` : `did not find`;
          this.log(`${outcome} service id=${id}`);
        }),
        catchError(this.handleError<Service>(`getService id=${id}`))
      );
  }

  /** GET service by id. Will 404 if id not found */
  getService(id: number): Observable<Service> {
    const url = `${this.serviceUrl}/${id}`;
    return this.http.get<Service>(url).pipe(
      tap(_ => this.log(`fetched service id=${id}`)),
      catchError(this.handleError<Service>(`getService id=${id}`))
    );
  }

  /* GET services whose name contains search term */
  searchServices(term: string): Observable<Service[]> {
    if (!term.trim()) {
      // if not search term, return empty service array.
      return of([]);
    }
    return this.http.get<Service[]>(`api/Service/?name=${term}`).pipe(
      tap(_ => this.log(`found services matching "${term}"`)),
      catchError(this.handleError<Service[]>('searchServices', []))
    );
  }

  //////// Save methods //////////

  /** POST: add a new service to the server */
  addService (service: Service): Observable<Service> {
    return this.http.post<Service>(this.serviceUrl, service, httpOptions).pipe(
      tap((service: Service) => this.log(`added service w/ id=${service.id}`)),
      catchError(this.handleError<Service>('addService'))
    );
  }

  /** DELETE: delete the service from the server */
  deleteService (service: Service | number): Observable<Service> {
    const id = typeof service === 'number' ? service : service.id;
    const url = `${this.serviceUrl}/${id}`;

    return this.http.delete<Service>(url, httpOptions).pipe(
      tap(_ => this.log(`deleted service id=${id}`)),
      catchError(this.handleError<Service>('deleteService'))
    );
  }

  /** PUT: update the service on the server */
  updateService (service: Service): Observable<any> {
    return this.http.put(this.serviceUrl, service, httpOptions).pipe(
      tap(_ => this.log(`updated service id=${service.id}`)),
      catchError(this.handleError<any>('updateService'))
    );
  }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  /** Log a ServiceService message with the MessageService */
  private log(message: string) {
    this.messageService.add('ServiceService: ' + message);
  }
}
